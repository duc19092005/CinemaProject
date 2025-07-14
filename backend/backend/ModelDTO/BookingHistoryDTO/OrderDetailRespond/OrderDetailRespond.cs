using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.BookingHistoryDTO.OrderDetailRespond
{
    public class OrderDetailRespond
    {

        public string customerName { get; set; } = string.Empty;

        public string phoneNumber { get; set; } = string.Empty;

        public string movieName { get; set; } = string.Empty;

        public DateTime movieScheduleDate { get; set; }

        public string ShowStatus { get; set; }

        public string cinemaName { get; set; } = string.Empty;

        public string scheduleShowTIme { get; set; } = string.Empty;

        public int cinemaRoomNumber { get; set; }

        public string SeatsNumber { get; set; } = string.Empty;

        public Dictionary<string, int> ProductList { get; set; } = [];
    }
}


