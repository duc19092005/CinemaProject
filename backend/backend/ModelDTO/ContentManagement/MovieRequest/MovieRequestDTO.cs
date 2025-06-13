using backend.Model.Cinemas;
using backend.Model.Movie;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace backend.ModelDTO.ContentManagement.MovieRequest
{
    public class MovieRequestDTO
    {
        [Required]

        public string movieName { get; set; } = "";
        [Required]

        // Tạm thời để byte
        public byte[] movieImage { get; set; } = [];
        [Required]

        public string movieDescription { get; set; } = "";

        [Required]
        public string movieDirector { get; set; } = "";

        [Required]
        // Diễn viên của bộ phim
        public string movieActor { get; set; } = "";
        [Required]

        // url Lưu trữ trailer của bộ phim
        public string movieTrailerUrl { get; set; } = "";

        // Thời lượng của bộ phim --------------!--------------- Chú ý : Tính bằng phút --------------!---------------
        [Required]
        public int movieDuration { get; set; }

        [Required]
        public string languageId { get; set; } = "";
        
        [Required]
        public List<string> visualFormatList { get; set; } = [];
        
        [Required]
        public List<string> movieGenreList {  get; set; } = [];

    }
}
