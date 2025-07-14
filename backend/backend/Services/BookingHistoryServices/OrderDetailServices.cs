using backend.Interface;
using backend.Data;
using Microsoft.EntityFrameworkCore;
using backend.ModelDTO.BookingHistoryDTO.OrderDetailRespond;
using backend.Interface.GenericsInterface;
using backend.ModelDTO.Customer.OrderRespond;
using backend.ModelDTO.BookingHistoryDTO.OrderRespond;
using System.Security.Cryptography.Xml;

namespace backend.Services.BookingHistoryServices
{
    // Parameter của Generic thứ 1 là dạng List . dạng 2 là dạng chi tiết
    public class OrderDetailServices : GenericInterface<BookingHistoryRespondList, OrderDetailRespond>
    {
        private readonly DataContext _dataContext;

        public OrderDetailServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<BookingHistoryRespondList>> getAll(string userID)
        {
            // Lấy OrderID

            var getOrderUserList = _dataContext.Order
                .Where(x => x.customerID.Equals(userID))
                .Select(x => x.orderId);

           
            var getTicketLists = await _dataContext.TicketOrderDetail
                .Where(x => getOrderUserList.Contains(x.orderId))
                .Include(tod => tod.movieSchedule) 
                    .ThenInclude(ms => ms.cinemaRoom) 
                        .ThenInclude(cr => cr.Cinema) 
                .Include(tod => tod.movieSchedule)
                    .ThenInclude(ms => ms.movieInformation) 
                .Include(tod => tod.movieSchedule)
                    .ThenInclude(ms => ms.HourSchedule) 
                .ToListAsync();

            // Tạo List để cho vào
            List<BookingHistoryRespondList> bookingHistoryRespondLists = new List<BookingHistoryRespondList>();
            foreach (var getTicketItems in getTicketLists)
            {
                string TrangThai = "Chưa chiếu";
                // Chuyển dạng 8:00 thành dạng thời gian để so sánh
                var convertToTimeSpan =
                    TimeSpan.ParseExact
                    (getTicketItems.movieSchedule.HourSchedule.HourScheduleShowTime, 
                    "h\\:mm", 
                    null);
                var convertToDateTime =
                    DateTime.Now.Date.Add(convertToTimeSpan);
                var newBookingHistoryRespondList = new BookingHistoryRespondList()
                {
                    cinemaName = getTicketItems.movieSchedule.cinemaRoom.Cinema.cinemaName,
                    cinemaRoomNumber = getTicketItems.movieSchedule.cinemaRoom.cinemaRoomNumber.ToString(),
                    DayInWeekend = getTicketItems.movieSchedule.DayInWeekendSchedule.ToString(),
                    HourSchedule = getTicketItems.movieSchedule.HourSchedule.HourScheduleShowTime,
                    movieName = getTicketItems.movieSchedule.movieInformation.movieName,
                    TrangThai = 
                    getTicketItems.movieSchedule.ScheduleDate > DateTime.Now 
                    &&
                    convertToDateTime > DateTime.Now ? "Đã chiếu" : TrangThai ,
                    NgayChieu = getTicketItems.movieSchedule.ScheduleDate.ToString("yyy/MM/dd"),
                };
                bookingHistoryRespondLists
                    .Add(newBookingHistoryRespondList);
            }
            return bookingHistoryRespondLists;
        }

        public async Task<OrderDetailRespond> getByID(string orderID)
        {
            // Dùng Include và then Include

            var getOrderDetail = _dataContext.Order
                .Where(x => x.orderId.Equals(orderID))
                // Join bảng Food
                // Join bảng Vé
                .Include(x => x.orderDetail)
                    .ThenInclude(x => x.movieSchedule)
                        .ThenInclude(x => x.movieInformation)
                .Include(x => x.orderDetail)
                    .ThenInclude(x => x.movieSchedule)
                        .ThenInclude(x => x.HourSchedule)
                .Include(x => x.Customer);
                


            // Trả về kết quả
            // Chỉ trả về một cái thôi
            // Khai báo biến

            string customerName = string.Empty;
            string phoneNumber = string.Empty;
            string movieName = string.Empty;
            DateTime scheduleDate = new DateTime();
            string cinemaName = string.Empty;
            string scheduleShowTime = string.Empty;
            string productList = string.Empty;
            int cinemaRoom = 0;
            bool Status = false;
            string seatList = string.Empty;

            // Trả về tên khách hàng Order
            var getCustomerInfo = getOrderDetail.Select(x => x.Customer).FirstOrDefault();

            // Trả về số điện thoại

            if (getCustomerInfo != null)
            {
                customerName = getCustomerInfo.Name;
               phoneNumber = getCustomerInfo.phoneNumber;
            }

            // Trả về thông tin phim

            var getOrderInfo = getOrderDetail.Select(x => x.orderDetail).FirstOrDefault();

            if (getOrderInfo != null)
            {
                // Lấy thông tin ghế người dùng đã đặt

                var getSeats = getOrderInfo.Select(x => x.Seats);
                seatList = String.Join(",", getSeats.Select(x => x.seatsNumber));
                var getScheduleInfo = getOrderInfo.Select(x => x.movieSchedule).FirstOrDefault();
                if (getScheduleInfo != null)
                {
                    scheduleDate = getScheduleInfo.ScheduleDate;

                    

                    // Tiếp tục lọc ra danh sách Giờ chiếu và phòng và Rạp và chọn ra nếu nó chiếu hoặc chưa
                    // 

                    // Lấy ra tên rạp
                    cinemaName = getScheduleInfo.cinemaRoom.Cinema.cinemaName;

                    // Lấy thông tin giờ chiếu

                    scheduleShowTime = getScheduleInfo.HourSchedule.HourScheduleShowTime;

                    // Convert sang dạng TimeSpan

                    var convertToTimeSpan =
                    TimeSpan.ParseExact
                    (scheduleShowTime,
                    "h\\:mm",
                    null);

                    // Convert sang dạng Giờ ngày

                    var convertToDateTime =
                        scheduleDate.Add(convertToTimeSpan);
                    // Lấy thông tin phòng

                    if (DateTime.Now < convertToDateTime)
                    {
                        Status = true;
                    }

                    cinemaRoom = getScheduleInfo.cinemaRoom.cinemaRoomNumber;

                    // Lấy ra danh sách sản phẩm người dùng Order

                    var getProductLists = await getOrderDetail.Select(x => x.orderDetailFood).FirstAsync();
                    if (getProductLists != null)
                    {
                        var getDetailProducts = getProductLists.Select(x => x.foodInformation.foodInformationName);

                        productList = String.Join(",", getDetailProducts);
                    }
                }
            }

            // Tạo object mới

            var newOrderDetailRespondDTO = new OrderDetailRespond()
            {
                cinemaName = cinemaName,
                cinemaRoomNumber = cinemaRoom,
                customerName = customerName,
                movieName = movieName,
                movieScheduleDate = scheduleDate,
                phoneNumber = phoneNumber,
                ProductList = productList,
                scheduleShowTIme = scheduleShowTime,
                SeatsNumber = seatList
            };

            return newOrderDetailRespondDTO;
        }
    }
}
