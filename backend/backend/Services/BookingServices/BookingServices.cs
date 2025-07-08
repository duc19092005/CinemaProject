using backend.Data;
using backend.Interface.BookingInterface;
using backend.Interface.VnpayInterface;
using backend.Model.Booking;
using backend.ModelDTO.Customer.OrderRequest;
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
        public async Task<string> booking(OrderRequestDTO orderRequestDTO , HttpContext httpContext)
        {
            if (orderRequestDTO.movieScheduleId == null)
            {
                // Xử lý trường hợp movieScheduleId là null
                return "Lỗi rồi không tìm thấy lịch chiếu";
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
                // Có thể cập nhật trạng thái bản ghi Order vừa tạo thành "Failed"
                return "Lỗi";
            }

            movieVisualID = findMovieSchedule.movieVisualFormatID.IsNullOrEmpty() ? "NullAble" : findMovieSchedule.movieVisualFormatID;

            // Lấy danh sách các UserTypeID từ yêu cầu
            var userTypeIds = orderRequestDTO.userTypeRequestDTO.Select(x => x.userTypeID).ToList();

            // Truy vấn priceInformationForEachUserFilmType hiệu quả hơn
            var relevantPriceInformationUserTypeVisualFormat = _dataContext.priceInformationForEachUserFilmType
                .Where(item => item.movieVisualFormatId.Equals(movieVisualID) && userTypeIds.Contains(item.userTypeId))
                .ToList();

            // Lấy ra các PriceInformationID duy nhất
            var priceIDList = relevantPriceInformationUserTypeVisualFormat
                .Select(item => item.priceInformationID)
                .ToList();

            // Truy vấn priceInformation chỉ cho các ID cần thiết
            var priceInformationForCalculation = await _dataContext.priceInformation
                .Where(price => priceIDList.Contains(price.priceInformationId))
                .ToListAsync();

            // Cộng giá hiệu quả
            totalAmount = priceInformationForCalculation.Sum(price => price.priceAmount);

            if (orderRequestDTO.foodRequestDTOs.Count() > 0)
            {
                // Truy vấn giá đồ ăn

                var ToDictionary = 
                    orderRequestDTO.foodRequestDTOs.ToDictionary(x => x.foodID, x => x.quantity);
                var getFoodID = 
                    ToDictionary.Select(x => x.Key);
                var getFoodPrice = 
                    _dataContext.foodInformation.Where(x => getFoodID.Contains(x.foodInformationId))
                    .ToDictionary(x => x.foodInformationId , x => x.foodPrice);

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

                totalAmount = totalAmountFood;
                    
            }


            var createdURL = vnpay.createURL(totalAmount, orderIDGenerate, httpContext);
            
            return "URL tới Trang VNPAY" + " " + createdURL + '\n' + "Tổng giá trị đơn hàng :" + " " + totalAmount;
            

        }
    }
}
