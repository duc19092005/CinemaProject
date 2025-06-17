using backend.Data;
using backend.Interface.GenericsInterface;
using backend.Model.Movie;
using backend.ModelDTO.MoviesDTO.MovieRequest;
using System.Data.Common;
using System.Linq;

namespace backend.Services.MovieServices
{
    public class movieServices : GenericInterface<MovieRequestDTO>
    {
        private readonly DataContext _dataContext;

        public movieServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> add(MovieRequestDTO movieRequestDTO)
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

        public async Task<bool> remove(int Id)
        {
            // Tìm kiếm Object

            var FindObjectMovieObject = await _dataContext.movieInformation.FindAsync(Id);

            // Thể loại  phim tìm kiếm

            var FindGenreObject = _dataContext.movieGenreInformation.Where(x => x.movieId.Equals(Id));

            // Tìm kiếm Comment 


            var FindCommentObject = _dataContext.movieCommentDetail.Where(x => x.movieId.Equals(Id));

            // Tìm kiếm lịch chiếu

            var FindMovieScheduleObject = _dataContext.movieSchedule.Where(x => x.movieId.Equals(Id) && !x.IsDelete).ToList();
            if (FindMovieScheduleObject.Count > 0)
            {
                var FindOrder = _dataContext.TicketOrderDetail.Any(x => x.movieScheduleID.Equals(FindMovieScheduleObject.Select(x => x.movieScheduleId)));
                // Nếu tìm thấy phim có lịch chiếu thì ko được xóa
                if (FindOrder)
                {
                    return false;
                }
                // nếu tìm thấy thì sẽ được xóa
                else
                {
                    // Nếu tìm thấy phim thì mới được xóa

                    if (FindObjectMovieObject != null)
                    {
                        _dataContext.movieGenreInformation.RemoveRange(FindGenreObject);
                        _dataContext.movieInformation.RemoveRange(FindObjectMovieObject);
                        _dataContext.movieCommentDetail.RemoveRange(FindCommentObject);

                        foreach (var movieSchedule in FindMovieScheduleObject)
                        {
                            movieSchedule.IsDelete = false;
                        }
                        
                        _dataContext.movieSchedule.UpdateRange(FindMovieScheduleObject);
                        return true;
                    }
                    return false;
                }    
            }
            return false;
        }

        public async Task<bool> edit(int Id, MovieRequestDTO movieRequestDTO)
        {
            return false;
        }

        public List<MovieRequestDTO> getListItems()
        {
            return null;
        }

        public async Task SaveChanges()
        {
            await _dataContext.SaveChangesAsync();
        }

    }
}
