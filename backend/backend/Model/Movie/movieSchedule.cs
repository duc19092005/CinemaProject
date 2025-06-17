using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;
using backend.Model.ScheduleList;

namespace backend.Model.Movie
{
    public class movieSchedule
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string movieScheduleId { get; set; } = "";

        [ForeignKey("cinemaRoom")]
        [Column(TypeName = "varchar(100)")]
        public string cinemaRoomId { get; set; } = "";

        [ForeignKey("movieInformation")]
        [Column(TypeName = "varchar(100)")]
        public string movieId { get; set; } = "";

        // Khóa ngoại tham chiếu tới thứ
        [ForeignKey("DayInWeekendSchedule")]
        public string DayInWeekendScheduleID { get; set; } = string.Empty;

        // Khóa ngoại tham chiếu tới giờ chiếu
        [ForeignKey("HourSchedule")]
        public string HourScheduleID { get; set; } = string.Empty;

        // Trạng thái của lịch chiếu

        public bool IsDelete { get; set; }

        public cinemaRoom cinemaRoom { get; set; } = null!;

        public movieInformation movieInformation { get; set; } = null!;

        public List<orderDetailTicket> orderDetailTicket { get; set; } = [];

        public DayInWeekendSchedule DayInWeekendSchedule { get; set; } = null!;

        public HourSchedule HourSchedule { get; set; } = null!;

    }
}
