using backend.Model.Movie;

namespace backend.ModelDTO.MoviesDTO.MovieRespond
{
    public class movieRespondDTO
    {
        public string movieID { get; set; } = string.Empty;

        public string movieName {  get; set; } = string.Empty;

        public string movieImage { get; set; } = string.Empty;

        public string movieTrailerUrl {  get; set; } = string.Empty;

        public int movieDuration { get; set; }

        public bool isRelease { get; set; } = false;

        public DateTime releaseDate { get; set; }

        public string ListLanguageName { get; set; } = string.Empty;

        public string[] movieVisualFormat { get; set; } = [];

        public string[] movieGenres { get; set; } = [];
    }
}
