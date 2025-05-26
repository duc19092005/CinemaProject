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

namespace backend.Model.Movie
{
    public class movieSchedule
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string movieScheduleId { get; set; } = "";

        public DateTime showDateTime { get; set; }

        [ForeignKey("cinemaRoom")]
        [Column(TypeName = "varchar(100)")]
        public string cinemaRoomId { get; set; } = "";

        [ForeignKey("movieInformation")]
        [Column(TypeName = "varchar(100)")]
        public string movieId { get; set; } = "";

        public cinemaRoom cinemaRoom { get; set; } = null!;

        public movieInformation movieInformation { get; set; } = null!;
    }
}
