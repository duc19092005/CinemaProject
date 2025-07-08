using backend.Data;
using backend.Interface.BookingInterface;
using backend.ModelDTO.Customer.OrderRequest;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace backend.Services.BookingServices
{
    public class BookingServices : IBookingServices
    {
        private readonly DataContext _dataContext;

        public BookingServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<bool> booking(OrderRequestDTO orderRequestDTO)
        {
            if (orderRequestDTO.movieScheduleId == null)
            {
                // Xử lý trường hợp movieScheduleId là null
                return false;
            }

            // Logic "Dù thất bại hay thành công đều phải add vào bảng" của bạn sẽ ở đây
            // Ví dụ: Tạo một bản ghi Order ban đầu với trạng thái pending

            if (orderRequestDTO.isPayment)
            {
                string movieVisualID = string.Empty;
                long totalAmount = 0;

                var findMovieSchedule = _dataContext.movieSchedule
                                                        .FirstOrDefault(x => x.movieScheduleId.Equals(orderRequestDTO.movieScheduleId));

                if (findMovieSchedule == null)
                {
                    // Có thể cập nhật trạng thái bản ghi Order vừa tạo thành "Failed"
                    return false;
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
                   
                }
                return true; // Giả định thanh toán thành công
            }
            else
            {
                // Xử lý trường hợp thanh toán thất bại hoặc chưa thanh toán
                // Có thể cập nhật trạng thái bản ghi Order vừa tạo thành "Pending" hoặc "Cancelled"
            }

            return false; // Nếu không vào được if (isPayment) hoặc có lỗi
        }
    }
}
