using backend.Data;
using backend.Interface.MovieInterfaces;
using backend.Model.Movie;
using backend.ModelDTO.MoviesDTO.MovieRequest;
using System.Data.Common;

namespace backend.Services.MovieServices
{
    public class movieServices : IMovie
    {
        private readonly DataContext _dataContext;

        public movieServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> uploadMovie(MovieRequestDTO movieRequestDTO)
        {
            if (movieRequestDTO != null)
            {
                // Generate New GUID 
                try
                {
                    var movieID = Guid.NewGuid();
                    byte[] imageBytes = new byte[1024];
                    using (var memory = new MemoryStream())
                    {
                        movieRequestDTO.movieImage.CopyTo(memory);
                        imageBytes = memory.ToArray();
                    }
                    var newMovie = new movieInformation()
                    {
                        movieId = movieID.ToString(),
                        movieName = movieRequestDTO.movieName,
                        movieImage = imageBytes,
                        movieDescription = movieRequestDTO.movieDescription,
                        movieDirector = movieRequestDTO.movieDirector,
                        movieTrailerUrl = movieRequestDTO.movieTrailerUrl,
                        movieDuration = movieRequestDTO.movieDuration,
                        languageId = movieRequestDTO.languageId,
                    };

                    await _dataContext.movieInformation.AddAsync(newMovie);

                    var newMovieGenreArray = new List<movieGenreInformation>();

                    foreach (var movieGenreID in movieRequestDTO.movieGenreList)
                    {
                        newMovieGenreArray.Add(new movieGenreInformation()
                        {
                            movieGenreId = movieGenreID,
                            movieId = movieID.ToString()
                        });
                    }

                    await _dataContext.movieGenreInformation.AddRangeAsync(newMovieGenreArray);

                    // Add Thể loại hình ảnh của phim

                    var newMovieVisualArray = new List<movieVisualFormatDetail>();

                    foreach (var movieVisualFormatID in movieRequestDTO.visualFormatList)
                    {
                        newMovieVisualArray.Add(new movieVisualFormatDetail()
                        {
                            movieId = movieID.ToString(),
                            movieVisualFormatId = movieVisualFormatID,
                        });
                    }
                    await _dataContext.movieVisualFormatDetails.AddRangeAsync(newMovieVisualArray);

                    await _dataContext.SaveChangesAsync();
                    return true;
                }
                catch (DbException db)
                {
                    throw new ApplicationException("Lỗi database" + db.Message);
                }
                catch (Exception e)
                {
                    throw new Exception("Lỗi hệ thống" + e.Message);
                }
            }
            return false;
        }

    }
}
