using backend.Interface;
using backend.Data;
using Microsoft.EntityFrameworkCore;
using backend.ModelDTO.BookingHistoryDTO.OrderDetailRespond;
using backend.Interface.GenericsInterface;
using backend.ModelDTO.Customer.OrderRespond;
using backend.ModelDTO.BookingHistoryDTO.OrderRespond;

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
            // Tiến hành tìm kiếm OrderID để làm cái chi tiết
            return null!;
        }
    }
}
