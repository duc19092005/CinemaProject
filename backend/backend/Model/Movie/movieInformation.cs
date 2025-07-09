using backend.Model.Movie;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Price;
using backend.Model.Product;
using Microsoft.EntityFrameworkCore;
using backend.Model.MinimumAge;

namespace backend.Model.Movie
{
    [Index(nameof(movieName), IsUnique = true)]
    [Index(nameof(movieImage), IsUnique = true)]
    [Index(nameof(movieTrailerUrl), IsUnique = true)]
    public class movieInformation
    {
        // Id của bộ phim 
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string movieId { get; set; } = "";

        [ForeignKey(nameof(minimumAge))]
        [Required]
        public string minimumAgeID { get; set; } = string.Empty;

        // Tên của bộ phim

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string movieName { get; set; } = "";

        [Required]
        public string movieImage { get; set; } = string.Empty;

        // Miêu tả của bộ phim

        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string movieDescription { get; set; } = "";

        // Đạo diễn của bộ phim
        [Required]
        [Column(TypeName = "nvarchar(200)")]

        public string movieDirector { get; set; } = "";

        // Diễn viên của bộ phim
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string movieActor { get; set; } = "";

        // url Lưu trữ trailer của bộ phim

        [Required]
        [Column(TypeName = "varchar(300)")]
        public string movieTrailerUrl { get; set; } = "";

        // Thời lượng của bộ phim --------------!--------------- Chú ý : Tính bằng phút --------------!---------------
        [Required]
        public int movieDuration { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public bool isDelete { get; set; } = false;

        [ForeignKey("Language")]
        [Column(TypeName = "varchar(100)")]
        [Required]

        public string languageId { get; set; } = "";

        public Language Language { get; set; } = null!;

        public minimumAge minimumAge { get; set; } = null!;

        public List<movieVisualFormatDetail> movieVisualFormatDetail { get; set; } = [];
        public List<movieSchedule> movieSchedule { get; set; } = null!;
        // Khóa ngoại 1 bộ phim có nhiều comment

        public List<movieGenreInformation> movieGenreInformation { get; set; } = [];

        public List<movieCommentDetail> movieCommentDetail { get; set; } = [];
    }
}
