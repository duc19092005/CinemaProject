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

        public string userId { get; set; } = "";

        public string orderId { get; set; } = "";

        public string userName { get; set; } = "";


        public string SeatsNumber { get; set; } = string.Empty;

        public string ProductList { get; set; } = string.Empty;
    }
}


