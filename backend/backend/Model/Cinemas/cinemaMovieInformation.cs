using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;

namespace backend.Model.Cinemas
{
    public partial class cinemaMovieInformation
    {
        [Column(TypeName = "varchar(100)")]
        [ForeignKey("Cinema")]
        public string cinemaId { get; set; } = "";

        [Column(TypeName = "varchar(100)")]
        [ForeignKey("movieInformation")]
        public string movieId { get; set; } = "";

        public Cinema Cinema { get; set; } = null!;

        public movieInformation movieInformation { get; set; } = null!;
    }

    [PrimaryKey(nameof(cinemaId), nameof(movieId))]
    public partial class cinemaMovieInformation
    {

    }
}
