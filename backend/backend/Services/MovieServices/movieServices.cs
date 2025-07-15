using backend.Data;
using backend.Interface.CloudinaryInterface;
using backend.Interface.GenericsInterface;
using backend.Interface.MovieInterface;
using backend.Model.MinimumAge;
using backend.Model.Movie;
using backend.ModelDTO.MoviesDTO.MovieRequest;
using backend.ModelDTO.MoviesDTO.MovieRespond;
using backend.ModelDTO.PaginiationDTO.Respond;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Globalization;
using System.Linq;

namespace backend.Services.MovieServices
{
    public class movieServices : IMovieService
    {
        private readonly DataContext _dataContext;

        private readonly ICloudinaryServices cloudinaryServices;

        public movieServices(DataContext dataContext , ICloudinaryServices cloudinaryServices)
        {
            _dataContext = dataContext;
            this.cloudinaryServices = cloudinaryServices;
        }

        public async Task<bool> add([FromForm] MovieRequestDTO movieRequestDTO)
        {
            if (movieRequestDTO != null)
            {
                // Generate New GUID 
                try
                {
                    var movieID = Guid.NewGuid();

                    var getFullUploadPath = await cloudinaryServices.uploadFileToCloudinary(movieRequestDTO.movieImage);
                    var newMovie = new movieInformation()
                    {
                        movieId = movieID.ToString(),
                        movieName = movieRequestDTO.movieName,
                        movieImage = getFullUploadPath,
                        movieDescription = movieRequestDTO.movieDescription,
                        movieDirector = movieRequestDTO.movieDirector,
                        movieTrailerUrl = movieRequestDTO.movieTrailerUrl,
                        movieDuration = movieRequestDTO.movieDuration,
                        languageId = movieRequestDTO.languageId,
                        minimumAgeID = movieRequestDTO.minimumAgeID,
                        ReleaseDate = movieRequestDTO.releaseDate,
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

        public async Task<bool> edit(int Id, MovieEditRequestDTO dtos)
        {

            // Tìm kiếm các trường dữ liệu liên quan
            var findLanguageAndMiniumAgeAndMovieInfo = _dataContext.movieInformation.Include
                (x => x.movieId.Equals(Id))
                .Include(x => x.Language)
                .Include(x => x.minimumAge)
                .FirstOrDefault();

            // Tìm kiếm Thể loại

            var findGenreFilm = _dataContext.movieGenreInformation
                .Where(x => x.movieId.Equals(Id));

            // Tìm kiếm định dạng hình ảnh

            var findMovieVisualFormatID = _dataContext.movieVisualFormatDetails
                .Where(x => x.movieId.Equals(Id));

            string movieName = string.Empty;
            string minumAgeID = string.Empty;
            string movieImage = string.Empty;
            string movieDescription = string.Empty;
            string movieDirector = string.Empty;
            string movieActor = string.Empty;
            string trailerURL = string.Empty;
            int movieDuration = 0;
            DateTime relaseDate = new DateTime();
            string languageID = string.Empty;

            List<string> visualFormatList = new List<string>();
            List<string> movieGenreList = new List<string>();

            // Nếu nó là null thì lấy chính nó

            if (findLanguageAndMiniumAgeAndMovieInfo != null)
            {
                if (String.IsNullOrEmpty(dtos.movieName))
                {
                    movieName = findLanguageAndMiniumAgeAndMovieInfo.movieName;
                }

                if (String.IsNullOrEmpty(dtos.minimumAgeID))
                {
                    minumAgeID = findLanguageAndMiniumAgeAndMovieInfo.minimumAgeID;
                }

                if (dtos.movieImage == null)
                {
                    movieImage = findLanguageAndMiniumAgeAndMovieInfo.movieImage;
                }

                if (String.IsNullOrEmpty(dtos.movieDescription))
                {
                    movieDescription = findLanguageAndMiniumAgeAndMovieInfo.movieDescription;
                }

                if (String.IsNullOrEmpty(dtos.movieDirector))
                {
                    movieDirector = findLanguageAndMiniumAgeAndMovieInfo.movieDirector;
                }

                if (String.IsNullOrEmpty(dtos.movieActor))
                {
                    movieActor = findLanguageAndMiniumAgeAndMovieInfo.movieActor;
                }

                if (String.IsNullOrEmpty(dtos.movieTrailerUrl))
                {
                    trailerURL = findLanguageAndMiniumAgeAndMovieInfo.movieTrailerUrl;
                }

                if (dtos.movieDuration == null)
                {
                    movieDuration = findLanguageAndMiniumAgeAndMovieInfo.movieDuration;
                }

                if (String.IsNullOrEmpty(dtos.languageId))
                {
                    languageID = findLanguageAndMiniumAgeAndMovieInfo.languageId;
                }

                if (dtos.releaseDate == null)
                {
                    relaseDate = findLanguageAndMiniumAgeAndMovieInfo.ReleaseDate;
                }

                if (dtos.movieGenreList == null)
                {
                    movieGenreList = findGenreFilm
                        .Select(x => x.movieGenreId).ToList();
                }

                if (dtos.visualFormatList == null)
                {
                    visualFormatList = findMovieVisualFormatID
                        .Select(x => x.movieVisualFormatId).ToList();
                }

                findLanguageAndMiniumAgeAndMovieInfo.movieName = movieDirector;
                findLanguageAndMiniumAgeAndMovieInfo.movieActor = movieActor;
                findLanguageAndMiniumAgeAndMovieInfo.movieDirector = movieDirector;
                findLanguageAndMiniumAgeAndMovieInfo.movieDuration = movieDuration;
                findLanguageAndMiniumAgeAndMovieInfo.languageId = languageID;
                findLanguageAndMiniumAgeAndMovieInfo.minimumAgeID = minumAgeID;
                findLanguageAndMiniumAgeAndMovieInfo.movieName = movieName;
                findLanguageAndMiniumAgeAndMovieInfo.ReleaseDate = relaseDate;
                findLanguageAndMiniumAgeAndMovieInfo.movieDescription = movieDescription;   
                var getFullUploadPath = await cloudinaryServices.uploadFileToCloudinary(dtos.movieImage);
                findLanguageAndMiniumAgeAndMovieInfo.movieImage = getFullUploadPath;
                return false;
            }
            return false;
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
                    movieImage = x.movieImage,
                    movieDuration = x.movieDuration,
                    movieGenres = x.movieGenreInformation.Select(mg => mg.movieGenre.movieGenreName).ToArray(),
                    ListLanguageName = x.Language.languageDetail,
                    movieTrailerUrl = x.movieTrailerUrl,
                    releaseDate = x.ReleaseDate,
                    movieVisualFormat = x.movieVisualFormatDetail.Select(vs => vs.movieVisualFormat.movieVisualFormatName).ToArray(),
                    isRelease = dateTime > x.ReleaseDate ? true : false,
                    minimumAge = 
                    _dataContext.minimumAges.FirstOrDefault(m => m.minimumAgeID.Equals(x.minimumAgeID)).minimumAgeInfo,
                    minimumAgeDescription = 
                    _dataContext.minimumAges.FirstOrDefault(m => m.minimumAgeID.Equals(x.minimumAgeID)).minimumAgeDescription
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
                    movieDuration = x.movieDuration,
                    movieGenres = x.movieGenreInformation.Select(mg => mg.movieGenre.movieGenreName).ToArray(),
                    ListLanguageName = x.Language.languageDetail,
                    movieTrailerUrl = x.movieTrailerUrl,
                    releaseDate = x.ReleaseDate,
                    movieVisualFormat = x.movieVisualFormatDetail.Select(vs => vs.movieVisualFormat.movieVisualFormatName).ToArray(),
                    isRelease = x.movieSchedule.Any(x => x.movieId.Equals(x.movieId) && dateTime >= x.ScheduleDate && !x.IsDelete) ? true : false,

                })
                .Take(5).ToListAsync();
            return getAllMovieData;
        }

        public Task<PagniationRespond> getFullSearchResult(string movieName, int page, int pagesize = 9)
        {
            return null!;
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
