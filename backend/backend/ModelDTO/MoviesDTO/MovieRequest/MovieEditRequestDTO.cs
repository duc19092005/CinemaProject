using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.MoviesDTO.MovieRequest
{
    public class MovieEditRequestDTO
    {
        public string? movieName { get; set; }
        public IFormFile? movieImage { get; set; }
        public string? movieDescription { get; set; }
        public string? movieDirector { get; set; }
        public string? movieActor { get; set; }
        public string? movieTrailerUrl { get; set; }

        // Thời lượng của bộ phim --------------!--------------- Chú ý : Tính bằng phút --------------!---------------
        public int? movieDuration { get; set; }

        public string? minimumAgeID { get; set; }
        public DateTime? releaseDate { get; set; }
        public string? languageId { get; set; }
        public List<string>? visualFormatList { get; set; }
        public List<string>? movieGenreList { get; set; }
    }
}
