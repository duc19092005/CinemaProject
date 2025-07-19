using backend.Model.MinimumAge;
using backend.Model.Movie;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.MoviesDTO.MovieRespond
{
    public class movieGetDetailResponseDTO
    {

        public string movieId { get; set; } = "";
        public string movieName { get; set; } = "";
        public string movieImage { get; set; } = string.Empty;
        public string movieDescription { get; set; } = "";
        public int minimumAge { get; set; } = 0;
        public string movieDirector { get; set; } = "";
        public string movieActor { get; set; } = "";
        public string movieTrailerUrl { get; set; } = "";
        public int movieDuration { get; set; }

        public DateTime ReleaseDate { get; set; }
        public string languageName { get; set; } = "";

        public string movieVisualFormat { get; set; } = string.Empty;

        public string movieGenre { get; set; }= string.Empty;
    }
}
