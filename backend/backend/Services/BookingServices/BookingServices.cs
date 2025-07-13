using backend.Data;
using backend.Enum;
using backend.Interface.BookingInterface;
using backend.Interface.VnpayInterface;
using backend.Model.Booking;
using backend.Model.Price;
using backend.ModelDTO.Customer.OrderRequest;
using backend.ModelDTO.Customer.OrderRespond;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Http; // Ensure this namespace is present

namespace backend.Services.BookingServices
{
    public class BookingServices : IBookingServices
    {
        private readonly DataContext _dataContext;
        private readonly IVnpayService _vnpayService; // Renamed for convention

        public BookingServices(DataContext dataContext, IVnpayService vnpayService)
        {
            _dataContext = dataContext;
            _vnpayService = vnpayService; // Assigned to the renamed field
        }

        public async Task<OrderRespondDTO> booking(OrderRequestDTO orderRequestDTO, HttpContext httpContext)
        {
            // --- Input Validation and Pre-checks ---
            if (string.IsNullOrEmpty(orderRequestDTO.userId)) // Using IsNullOrEmpty for string IDs
            {
                return new OrderRespondDTO { Error = "Error: User ID is missing." };
            }

            var customer = await _dataContext.Customers
                                             .FirstOrDefaultAsync(c => c.Id == orderRequestDTO.userId); // Use FirstOrDefaultAsync
            if (customer == null)
            {
                return new OrderRespondDTO { Error = "Error: User not found." };
            }

            if (string.IsNullOrEmpty(orderRequestDTO.movieScheduleId)) // Using IsNullOrEmpty for string IDs
            {
                return new OrderRespondDTO { Error = "Error: Movie schedule is empty." };
            }

            var requestedTotalSeats = orderRequestDTO.seatsRequestDTOs?.Count() ?? 0;
            var userTypeQuantitySum = orderRequestDTO.userTypeRequestDTO?.Sum(x => x.quantity) ?? 0;

            if (requestedTotalSeats == 0 || requestedTotalSeats != userTypeQuantitySum)
            {
                return new OrderRespondDTO { Error = "Error: Number of seats selected is incorrect or missing." };
            }

            var movieSchedule = await _dataContext.movieSchedule
                                                .FirstOrDefaultAsync(ms => ms.movieScheduleId == orderRequestDTO.movieScheduleId);
            if (movieSchedule == null)
            {
                return new OrderRespondDTO { Error = "Error: Movie schedule not found." };
            }

            var requestedSeatIds = orderRequestDTO.seatsRequestDTOs.Select(s => s.seatID).ToList();
            if (!requestedSeatIds.Any()) // Check if any seat IDs were actually provided
            {
                return new OrderRespondDTO { Error = "Error: No seats selected for booking." };
            }

            var existingTakenSeats = await _dataContext.Seats
                .Where(s => requestedSeatIds.Contains(s.seatsId) && s.isTaken)
                .ToListAsync();

            if (existingTakenSeats.Any())
            {
                var takenSeatNumbers = string.Join(", ", existingTakenSeats.Select(s => s.seatsNumber));
                return new OrderRespondDTO
                {
                    Error = $"Error: The following seats are already taken. Please choose different seats: {takenSeatNumbers}"
                };
            }

            // --- Calculate Total Amount ---
            long totalAmount = 0;
            string movieVisualId = movieSchedule.movieVisualFormatID.IsNullOrEmpty() ? "NullAble" : movieSchedule.movieVisualFormatID;

            // Calculate ticket price
            if (orderRequestDTO.userTypeRequestDTO != null && orderRequestDTO.userTypeRequestDTO.Any())
            {
                var userTypeRequests = orderRequestDTO.userTypeRequestDTO.ToDictionary(x => x.userTypeID, x => x.quantity);
                var userTypeIds = userTypeRequests.Keys;

                // Get relevant price information mappings
                var priceMappings = await _dataContext.priceInformationForEachUserFilmType
                    .Where(x => userTypeIds.Contains(x.userTypeId) && x.movieVisualFormatId == movieVisualId)
                    .ToDictionaryAsync(x => x.userTypeId, x => x.priceInformationID);

                // Get actual prices
                var priceInformationIds = priceMappings.Values;
                var prices = await _dataContext.priceInformation
                    .Where(p => priceInformationIds.Contains(p.priceInformationId))
                    .ToDictionaryAsync(p => p.priceInformationId, p => p.priceAmount);

                foreach (var userTypeReq in userTypeRequests)
                {
                    if (priceMappings.TryGetValue(userTypeReq.Key, out string priceInfoId))
                    {
                        if (prices.TryGetValue(priceInfoId, out long pricePerUnit))
                        {
                            totalAmount += pricePerUnit * userTypeReq.Value;
                        }
                        else
                        {
                            // Log or handle case where price information is missing for a valid priceInfoId
                            Console.WriteLine($"Warning: Price information not found for PriceInfoID: {priceInfoId}");
                        }
                    }
                    else
                    {
                        // Log or handle case where a userTypeID doesn't have a valid price mapping
                        Console.WriteLine($"Warning: Price mapping not found for UserTypeID: {userTypeReq.Key} and MovieVisualID: {movieVisualId}");
                    }
                }
            }

            // Calculate food price
            if (orderRequestDTO.foodRequestDTOs != null && orderRequestDTO.foodRequestDTOs.Any())
            {
                var foodRequests = orderRequestDTO.foodRequestDTOs.ToDictionary(f => f.foodID, f => f.quantity);
                var foodIds = foodRequests.Keys;

                var foodPrices = await _dataContext.foodInformation
                    .Where(f => foodIds.Contains(f.foodInformationId))
                    .ToDictionaryAsync(f => f.foodInformationId, f => f.foodPrice);

                foreach (var foodReq in foodRequests)
                {
                    if (foodPrices.TryGetValue(foodReq.Key, out long foodPrice))
                    {
                        totalAmount += foodPrice * foodReq.Value;
                    }
                    else
                    {
                        Console.WriteLine($"Warning: Food price not found for FoodID: {foodReq.Key}");
                    }
                }
            }

            // --- Generate Order ID and VNPAY URL ---
            var orderId = Guid.NewGuid().ToString();
            string vnpayUrl;
            try
            {
                vnpayUrl = _vnpayService.createURL(totalAmount, orderId, httpContext);
            }
            catch (Exception ex)
            {
                // Handle VNPAY URL creation failure
                Console.WriteLine($"Error creating VNPAY URL: {ex.Message}");
                return new OrderRespondDTO { Error = "Error: Failed to create payment URL." };
            }

            // --- Database Transaction ---
            await using var transaction = await _dataContext.Database.BeginTransactionAsync(); // Use await using for async disposal
            try
            {
                // Create Order
                var order = new Order
                {
                    orderId = orderId,
                    paymentRequestCreatedDate = DateTime.Now,
                    PaymentStatus = PaymentStatus.Pending.ToString(),
                    totalAmount = totalAmount,
                    customerID = orderRequestDTO.userId,
                };
                await _dataContext.Order.AddAsync(order);

                // Create Ticket Order Details
                var orderDetailTickets = orderRequestDTO.seatsRequestDTOs
                    .Select(s => new orderDetailTicket
                    {
                        orderId = orderId,
                        movieScheduleID = orderRequestDTO.movieScheduleId,
                        seatsId = s.seatID
                    })
                    .ToList();
                await _dataContext.TicketOrderDetail.AddRangeAsync(orderDetailTickets);

                // Update Seat Status
                var seatsToUpdate = await _dataContext.Seats
                    .Where(s => requestedSeatIds.Contains(s.seatsId))
                    .ToListAsync();

                foreach (var seat in seatsToUpdate)
                {
                    seat.isTaken = true;
                }
                _dataContext.Seats.UpdateRange(seatsToUpdate);

                // Create Food Order Details
                if (orderRequestDTO.foodRequestDTOs != null && orderRequestDTO.foodRequestDTOs.Any())
                {
                    var orderDetailFoods = orderRequestDTO.foodRequestDTOs
                        .Select(f => new orderDetailFood
                        {
                            orderId = orderId,
                            quanlity = f.quantity,
                            foodInformationId = f.foodID,
                        })
                        .ToList();
                    await _dataContext.FoodOrderDetail.AddRangeAsync(orderDetailFoods);
                }

                await _dataContext.SaveChangesAsync();
                await transaction.CommitAsync();

                return new OrderRespondDTO
                {
                    VnpayURL = vnpayUrl,
                    TotalAmount = totalAmount
                };
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine($"Database transaction error during booking: {ex.ToString()}"); // Log full exception
                return new OrderRespondDTO
                {
                    Error = "Error: System failed to save order to the database. Please try again."
                };
            }
        }
    }
}