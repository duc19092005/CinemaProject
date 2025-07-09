using backend.Data;
using backend.Enum;
using backend.Interface.BookingInterface;
using backend.Interface.VnpayInterface;
using backend.Model.Booking;
using backend.Model.Price;
using backend.ModelDTO.Customer.OrderRequest;
using backend.ModelDTO.Customer.OrderRespond;
using backend.ModelDTO.VNPAY;
using backend.Services.VnpayServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace backend.Services.BookingServices
{
    public class BookingServices : IBookingServices
    {
        private readonly DataContext _dataContext;

        private readonly IVnpayService vnpay;

        public BookingServices(DataContext dataContext , IVnpayService vnpayService)
        {
            _dataContext = dataContext;
            vnpay = vnpayService;
        }
        public async Task<OrderRespondDTO> booking(OrderRequestDTO orderRequestDTO , HttpContext httpContext)
        {
            if (orderRequestDTO.movieScheduleId == null)
            {
                // Xử lý trường hợp movieScheduleId là null
                return new OrderRespondDTO()
                {
                    Error = "Lịch chiếu bị trống"
                };
            }

            var userTypeSum = orderRequestDTO.userTypeRequestDTO.Sum(x => x.quantity);
            if (orderRequestDTO.seatsRequestDTOs.Count() < userTypeSum || orderRequestDTO.seatsRequestDTOs.Count() > userTypeSum)
            {
                return new OrderRespondDTO()
                {
                    Error = "Số ghế đặt bị dư hoặc thiếu"
                };
            }


                var orderIDGenerate = Guid.NewGuid().ToString();
            // Logic "Dù thất bại hay thành công đều phải add vào bảng" của bạn sẽ ở đây
            // Ví dụ: Tạo một bản ghi Order ban đầu với trạng thái pending

            string movieVisualID = string.Empty;
            long totalAmount = 0;
            var findMovieSchedule = _dataContext.movieSchedule
                                                    .FirstOrDefault(x => x.movieScheduleId.Equals(orderRequestDTO.movieScheduleId));

            if (findMovieSchedule == null)
            {
                return new OrderRespondDTO()
                {
                    Error = "Không tìm thấy lịch chiếu phim"
                };
            }

            var requestedSeatIds = orderRequestDTO.seatsRequestDTOs.Select(s => s.seatID).ToList();

            var existingTakenSeats = await _dataContext.Seats
                .Where(s => requestedSeatIds.Contains(s.seatsId) && s.isTaken)
                .ToListAsync();

            if (existingTakenSeats.Any())
            {
                var takenSeatNames = string.Join(", ", existingTakenSeats.Select(s => s.seatsNumber));
                return new OrderRespondDTO()
                {
                    Error = $"Các ghế sau đã được đặt vui lòng chuyển ghế khác {takenSeatNames}"
                };
            }

            movieVisualID = findMovieSchedule.movieVisualFormatID.IsNullOrEmpty() ? "NullAble" : findMovieSchedule.movieVisualFormatID;

            // Lấy danh sách các UserTypeID từ yêu cầu
            var userTypeIds = orderRequestDTO
                .userTypeRequestDTO.ToList();

            // Chọn ra userTypeID

            // Theo Logic nếu usertypeID ban đầu và visualID ban đầu bằng với price
            // thì sẽ nhân với số lượng của userTypeID của requeset

            var getUserTypeIDs = userTypeIds.
                Select(x => x.userTypeID);

            // Truy vấn PriceID
            // Lọc được giá

            var getPriceIDForeachUserType = _dataContext.priceInformationForEachUserFilmType
                .Where(x => getUserTypeIDs.Contains(x.userTypeId))
                .Select(x => x.priceInformationID);

            // Truy vấn Giá gốc
            // Cái này là đã lấy được giá đã được lọc theo userTypeID visualFormatID

            // Lấy được Tất cả Danh sách
            var getPriceInformation =
                _dataContext.priceInformation
                .Where(x => getPriceIDForeachUserType
                .Contains(x.priceInformationId))
                .ToList();


            // Lấy priceID để chủ động tìm kiếm giá

            var getUserTypeAndPriceID = _dataContext.priceInformationForEachUserFilmType
                .Where(x => getUserTypeIDs.Contains(x.userTypeId)
                && x.movieVisualFormatId.Equals(movieVisualID)
                && getPriceIDForeachUserType.Contains(x.priceInformationID))
                .ToDictionary(x => x.userTypeId, x => x.priceInformationID);

            // Xuất ra quantity

            var toDictionaryRequestsDTO = userTypeIds.ToDictionary(x => x.userTypeID, x => x.quantity);

            var priceLookup = getPriceInformation.ToDictionary(x => x.priceInformationId, x => x.priceAmount);


            foreach (var getQuantityAndUserType in toDictionaryRequestsDTO)
            {
                // Lấy userTypeID
                string userTypeID = getQuantityAndUserType.Key;
                // Lấy số lượng 
                int Quantity = getQuantityAndUserType.Value;

                if (getUserTypeAndPriceID.TryGetValue(userTypeID, out string priceInfoID))
                {
                    if (priceLookup.TryGetValue(priceInfoID, out long priceID))
                    {
                        totalAmount += priceID * Quantity;
                    }
                }

            }
            if (orderRequestDTO.foodRequestDTOs.Count() > 0)
            {
                // Truy vấn giá đồ ăn

                var ToDictionary =
                    orderRequestDTO.foodRequestDTOs.ToDictionary(x => x.foodID, x => x.quantity);
                var getFoodID =
                    ToDictionary.Select(x => x.Key);
                var getFoodPrice =
                    _dataContext.foodInformation.Where(x => getFoodID.Contains(x.foodInformationId))
                    .ToDictionary(x => x.foodInformationId, x => x.foodPrice);

                long totalAmountFood = 0;

                foreach (var foodInfo in ToDictionary)
                {
                    string foodID = foodInfo.Key;
                    int foodQuantity = foodInfo.Value;

                    if (getFoodPrice.TryGetValue(foodID, out long price))
                    {
                        totalAmountFood += foodQuantity * price;
                    }
                }

                totalAmount += totalAmountFood;

            }


            var createdURL = vnpay.createURL(totalAmount, orderIDGenerate, httpContext);

            // Lưu thông tin thanh toán

            var transation = _dataContext.Database.BeginTransaction();
            try
            {
                await _dataContext.Order.AddAsync(new Order()
                {
                    orderId = orderIDGenerate,
                    paymentRequestCreatedDate = DateTime.Now,
                    PaymentStatus = PaymentStatus.Pending.ToString(),
                    totalAmount = totalAmount ,
                    customerID = orderRequestDTO.userId,
                    
                });

                List<orderDetailTicket> orderDetailTickets = new List<orderDetailTicket>();
                foreach (var seatsID in orderRequestDTO.seatsRequestDTOs)
                {
                    orderDetailTickets.Add(new orderDetailTicket()
                    {
                        orderId = orderIDGenerate,
                        movieScheduleID = orderRequestDTO.movieScheduleId,
                        seatsId = seatsID.seatID
                    });
                }
                await _dataContext.TicketOrderDetail.AddRangeAsync(orderDetailTickets);
                // Sau khi luuw voo trong DB thành công tiến hành cập nhật trạng thái ghế
                var getSeats = _dataContext.Seats
                    .Where(x => orderRequestDTO.seatsRequestDTOs
                    .Select(x => x.seatID)
                    .Contains(x.seatsId)).ToList();
                foreach (var setSeatsStatus in getSeats)
                {
                    setSeatsStatus.isTaken = true;
                }

                _dataContext.Seats.UpdateRange(getSeats);
                if (orderRequestDTO.foodRequestDTOs.Count() > 0)
                {
                    List<orderDetailFood> orderDetailFoods = new List<orderDetailFood>();
                    foreach (var foods in orderRequestDTO.foodRequestDTOs)
                    {
                        orderDetailFoods.Add(new orderDetailFood()
                        {
                            orderId = orderIDGenerate,
                            quanlity = foods.quantity,
                            foodInformationId = foods.foodID,
                        });
                    }
                    await _dataContext.FoodOrderDetail.AddRangeAsync(orderDetailFoods);
                }
                await _dataContext.SaveChangesAsync();
                await transation.CommitAsync();
                return new OrderRespondDTO()
                {
                    VnpayURL = createdURL,
                    TotalAmount = totalAmount
                };
            }
            catch (Exception ex)
            {
                await transation.RollbackAsync();
                Console.WriteLine(ex.ToString());
                return new OrderRespondDTO()
                {
                    Error = "Lỗi Hệ thống Không lưu được trên Database"
                };
            }
        }
    }
}
