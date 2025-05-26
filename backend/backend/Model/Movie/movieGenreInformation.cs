using Microsoft.EntityFrameworkCore;
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
    // Bảng này được tạo ra mục đích là chỉ ra mối quan hệ nhiều nhiều

    public partial class movieGenreInformation
    {
        [ForeignKey("movieInformation")]
        [Column(TypeName = "varchar(100)")]
        public string movieId { get; set; } = "";

        [ForeignKey("movieGenre")]
        [Column(TypeName = "varchar(100)")]
        public string movieGenreId { get; set; } = "";

        public movieInformation movieInformation { get; set; } = null!;

        public movieGenre movieGenre { get; set; } = null!;
    }

    [PrimaryKey(nameof(movieId), nameof(movieGenreId))]
    public partial class movieGenreInformation
    {

    }
}
