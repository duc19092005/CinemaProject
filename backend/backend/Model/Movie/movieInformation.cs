using backend.Model.Movie;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Price;
using backend.Model.Product;

namespace backend.Model.Movie
{
    public class movieInformation
    {
        // Id của bộ phim 
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string movieId { get; set; } = "";

        // Tên của bộ phim

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string movieName { get; set; } = "";

        [Required]
        public byte[] movieImage { get; set; } = [];

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

        [ForeignKey("Language")]
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string languageId { get; set; } = "";

        [ForeignKey("movieVisualFormat")]
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string movieVisualFormatId { get; set; } = "";

        public Language Language { get; set; } = null!;

        public movieVisualFormat movieVisualFormat { get; set; } = null!;

        public List<movieSchedule> movieSchedule { get; set; } = null!;

        public List<cinemaMovieInformation> cinemaMovieInformation { get; set; } = [];

        // Khóa ngoại 1 bộ phim có nhiều comment

        public List<movieCommentDetail> movieCommentDetail { get; set; } = [];
    }
}
