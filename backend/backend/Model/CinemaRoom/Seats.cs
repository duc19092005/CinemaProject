using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;
using Microsoft.EntityFrameworkCore;

namespace backend.Model.CinemaRoom
{
    [Index(nameof(seatsId))]
    [Index(nameof(cinemaRoomId))]
    public class Seats
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string seatsId { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        public string seatsNumber { get; set; } = "";

        [Required]
        public bool isTaken { get; set; } = false;

        [Required]
        public bool isDelete { get; set; } = false;

        [Column(TypeName = "varchar(100)")]
        [ForeignKey("cinemaRoom")]
        public string cinemaRoomId { get; set; } = "";

        public cinemaRoom cinemaRoom { get; set; } = null!;

        public List<orderDetailTicket> orderDetail = [];


    }
}
