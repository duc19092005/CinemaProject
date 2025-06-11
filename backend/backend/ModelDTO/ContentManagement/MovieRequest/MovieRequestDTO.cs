using backend.Model.Cinemas;
using backend.Model.Movie;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.ContentManagement.MovieRequest
{
    public class MovieRequestDTO
    {
        public string movieName { get; set; } = "";

        // Tạm thời để byte
        public byte[] movieImage { get; set; } = [];

        public string movieDescription { get; set; } = "";

        [Required]
        public string movieDirector { get; set; } = "";

        // Diễn viên của bộ phim
        public string movieActor { get; set; } = "";

        // url Lưu trữ trailer của bộ phim
        public string movieTrailerUrl { get; set; } = "";

        // Thời lượng của bộ phim --------------!--------------- Chú ý : Tính bằng phút --------------!---------------
        [Required]
        public int movieDuration { get; set; }

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
