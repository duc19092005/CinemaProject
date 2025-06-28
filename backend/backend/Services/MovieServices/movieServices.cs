using backend.Data;
using backend.Interface.GenericsInterface;
using backend.Interface.MovieInterface;
using backend.Model.Movie;
using backend.ModelDTO.MoviesDTO.MovieRequest;
using backend.ModelDTO.MoviesDTO.MovieRespond;
using backend.ModelDTO.PaginiationDTO.Respond;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Linq;

namespace backend.Services.MovieServices
{
    public class movieServices : IMovieService
    {
        private readonly DataContext _dataContext;

        public movieServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> add([FromForm] MovieRequestDTO movieRequestDTO)
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

        // Không xóa phim chỉ set bằng isDelete = true thôi
        public async Task<bool> remove(string Id)
        {
            // Tìm kiếm Object

            var FindObjectMovieObject = await  _dataContext.movieInformation.FindAsync(Id);

            // Thể loại  phim tìm kiếm

            var FindGenreObject = _dataContext.movieGenreInformation.Where(x => x.movieId.Equals(Id));

            // Tìm kiếm Comment 

            var FindCommentObject = _dataContext.movieCommentDetail.Where(x => x.movieId.Equals(Id));

            // Tìm kiếm lịch chiếu

            if (FindObjectMovieObject != null)
            {
                var FindMovieScheduleObject = _dataContext.movieSchedule.Where(x => x.movieId.Equals(FindObjectMovieObject.movieId) && !x.IsDelete).ToList();
                var FindOrder = _dataContext.TicketOrderDetail.Any(x => x.movieScheduleID.Equals(FindMovieScheduleObject.Select(x => x.movieScheduleId)));
                if (!FindOrder)
                {
                    FindObjectMovieObject.isDelete = true;

                    _dataContext.movieInformation.Update(FindObjectMovieObject);

                    foreach (var movieSchedule in FindMovieScheduleObject)
                    {
                        movieSchedule.IsDelete = true;
                    }

                    _dataContext.movieSchedule.UpdateRange(FindMovieScheduleObject);
                    return true;
                }
                else
                {

                    return false;
                }
            }
            return false;
        }

        public async Task<bool> edit(int Id, MovieRequestDTO movieRequestDTO)
        {
            return false;
        }

        public async Task<List<movieRespondDTO>> getListItemsHomePage()
        {
            DateTime dateTime = DateTime.Now;
            var getAllMovieData = await _dataContext.movieInformation
                .Select(x => new movieRespondDTO()
                {
                    movieName = x.movieName,
                    movieID = x.movieId,
                    movieActor = x.movieActor,
                    movieDescription = x.movieDescription,
                    movieDuration = x.movieDuration,
                    movieGenres = x.movieGenreInformation.Select(mg => mg.movieGenre.movieGenreName).ToArray(),
                    ListLanguageName = x.Language.languageDetail,
                    movieTrailerUrl = x.movieTrailerUrl,
                    movieVisualFormat = x.movieVisualFormatDetail.Select(vs => vs.movieVisualFormat.movieVisualFormatName).ToArray(),
                    isRelease = x.movieSchedule.Any(x => x.movieId.Equals(x.movieId) && dateTime >= x.ScheduleDate && !x.IsDelete) ? true : false,
                }).ToListAsync();
            return getAllMovieData;
        }

        public async Task<PagniationRespond> getListItemsPagination(int page, int pagesize = 9)
        {
            // Lấy giờ hiện tại
            DateTime dateTime = DateTime.Now;
            var getAllData = _dataContext.movieInformation.ToList();
            var getAllMovieData = await _dataContext.movieInformation
                .Select(x => new movieRespondDTO()
                {
                    movieName = x.movieName,
                    movieID = x.movieId,
                    movieActor = x.movieActor,
                    movieDescription = x.movieDescription,
                    movieDuration = x.movieDuration,
                    movieGenres = x.movieGenreInformation.Select(mg => mg.movieGenre.movieGenreName).ToArray(),
                    ListLanguageName = x.Language.languageDetail,
                    movieTrailerUrl = x.movieTrailerUrl,
                    movieVisualFormat = x.movieVisualFormatDetail.Select(vs => vs.movieVisualFormat.movieVisualFormatName).ToArray(),
                    isRelease = x.movieSchedule.Any(x => x.movieId.Equals(x.movieId) && dateTime >= x.ScheduleDate && !x.IsDelete) ? true : false,
                }).
                Take(pagesize).Skip((page - 1) * pagesize).
                ToListAsync();
            var newPagniationRespond = new PagniationRespond()
            {
                movieRespondDTOs = getAllMovieData,
                page = page,
                pageSize = (int)Math.Ceiling((double)getAllData.Count() / pagesize),
                totalCount = getAllData.Count,
            };
            return newPagniationRespond;
        }

        public async Task<List<movieRespondDTO>> getListMoviesByNameTake5(string movie)
        {
            DateTime dateTime = DateTime.Now;
            var getAllMovieData = await _dataContext.movieInformation
                .Where(x => x.movieName.Contains(movie))
                .Select(x => new movieRespondDTO()
                {
                    movieName = x.movieName,
                    movieID = x.movieId,
                    movieActor = x.movieActor,
                    movieDescription = x.movieDescription,
                    movieDuration = x.movieDuration,
                    movieGenres = x.movieGenreInformation.Select(mg => mg.movieGenre.movieGenreName).ToArray(),
                    ListLanguageName = x.Language.languageDetail,
                    movieTrailerUrl = x.movieTrailerUrl,
                    movieVisualFormat = x.movieVisualFormatDetail.Select(vs => vs.movieVisualFormat.movieVisualFormatName).ToArray(),
                    isRelease = x.movieSchedule.Any(x => x.movieId.Equals(x.movieId) && dateTime >= x.ScheduleDate && !x.IsDelete) ? true : false,

                })
                .Take(5).ToListAsync();
            return getAllMovieData;
        }

        public async Task<List<movieRespondDTO>> getListMoviesByName(string movie)
        {
            DateTime dateTime = DateTime.Now;
            var getAllMovieData = await _dataContext.movieInformation
                .Where(x => x.movieName.Contains(movie))
                .Select(x => new movieRespondDTO()
                {
                    movieName = x.movieName,
                    movieID = x.movieId,
                    movieActor = x.movieActor,
                    movieDescription = x.movieDescription,
                    movieDuration = x.movieDuration,
                    movieGenres = x.movieGenreInformation.Select(mg => mg.movieGenre.movieGenreName).ToArray(),
                    ListLanguageName = x.Language.languageDetail,
                    movieTrailerUrl = x.movieTrailerUrl,
                    movieVisualFormat = x.movieVisualFormatDetail.Select(vs => vs.movieVisualFormat.movieVisualFormatName).ToArray(),
                    isRelease = x.movieSchedule.Any(x => x.movieId.Equals(x.movieId) && dateTime >= x.ScheduleDate && !x.IsDelete) ? true : false,

                }).ToListAsync();
            return getAllMovieData;
        }

        public async Task SaveChanges()
        {
            await _dataContext.SaveChangesAsync();
        }

    }
}
