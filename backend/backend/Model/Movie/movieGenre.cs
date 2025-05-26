using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;

namespace backend.Model.Movie
{
    // Đây là bảng thể loại phim 

    public class movieGenre
    {

        // ID thể loại phim

        [Key]
        [Column(TypeName = "varchar(100)")]
        public string movieGenreId { get; set; } = "";


        // thông tin của thể loại bộ phim

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string movieGenreName { get; set; } = "";
    }
}
