using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Booking
{
    public partial class orderDetailTicket
    {
        [Column(TypeName = "varchar(100)")]
        [ForeignKey("Order")]
        public string orderId { get; set; } = "";

        [Column(TypeName = "varchar(100)")]
        [ForeignKey("movieSchedule")]
        public string movieScheduleID { get; set; } = string.Empty;

        [Column(TypeName = "varchar(100)")]
        [ForeignKey("Seats")]
        public string seatsId { get; set; } = "";

        public Order Order { get; set; } = null!;

        public Seats Seats { get; set; } = null!;

        public movieSchedule movieSchedule { get; set; } = null!;
    }

    [PrimaryKey(nameof(seatsId) , nameof(movieScheduleID) , nameof(orderId))]
    public partial class orderDetailTicket
    {

    }
}
