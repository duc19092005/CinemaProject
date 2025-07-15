using backend.Data;
using backend.Enum;
using backend.Interface.CloudinaryInterface;
using backend.Interface.GenericsInterface;
using backend.Interface.MovieInterface;
using backend.Model.MinimumAge;
using backend.Model.Movie;
using backend.ModelDTO.GenericRespond;
using backend.ModelDTO.MoviesDTO.MovieRequest;
using backend.ModelDTO.MoviesDTO.MovieRespond;
using backend.ModelDTO.PaginiationDTO.Respond;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

        public GenericRespondWithObjectDTO<movieGetDetailResponseDTO> getMovieDetail(string movieID)
        {
            var findMovieInfo = _dataContext.movieInformation
                .Where(x => x.movieId.Equals(movieID))
                .Include(x => x.Language)
                .Include(x => x.minimumAge)
                .FirstOrDefault();
            if (findMovieInfo != null)
            {
                // Tiến hành lọc thông tin
                var findMovieVisualFormat = _dataContext.movieVisualFormatDetails
                    .Where(x => x.movieId == movieID)
                    .Include(x => x.movieVisualFormat);

                var findMovieGenre = _dataContext.movieGenreInformation.
                    Where(x => x.movieId == movieID)
                    .Include(x => x.movieGenre);

                return new GenericRespondWithObjectDTO<movieGetDetailResponseDTO>()
                {
                    Status = GenericStatusEnum.Success.ToString(),
                    message = "Tìm chi tiết phim thành công",
                    data = new movieGetDetailResponseDTO()
                    {
                        movieId = movieID,
                        movieVisualFormat = string.Join("," , findMovieVisualFormat.Select(x => x.movieVisualFormat.movieVisualFormatName)) ,
                        movieGenre = string.Join("," , findMovieGenre.Select(x => x.movieGenre.movieGenreName)) ,
                        movieDirector = findMovieInfo.movieDirector,
                        movieImage = findMovieInfo.movieImage,
                        movieTrailerUrl = findMovieInfo.movieTrailerUrl,
                        ReleaseDate = findMovieInfo.ReleaseDate,
                        movieName = findMovieInfo.movieName,
                        movieActor = findMovieInfo.movieActor,
                        movieDescription = findMovieInfo.movieDescription,
                        movieDuration = findMovieInfo.movieDuration,
                        languageName = findMovieInfo.Language.languageDetail,
                        minimumAge = findMovieInfo.minimumAge.minimumAgeInfo,
                    }
                };
            }
            return new GenericRespondWithObjectDTO<movieGetDetailResponseDTO>()
            {
                Status = GenericStatusEnum.Failure.ToString(),
                message = "Không tìm thấy phim , vui lòng thử lại sau"
            };
        }


        public async Task<bool> edit(string movieID, MovieEditRequestDTO dtos)
        {

            // Tìm kiếm các trường dữ liệu liên quan
            var findLanguageAndMiniumAgeAndMovieInfo = _dataContext.movieInformation.Where
                (x => x.movieId.Equals(movieID))
                .Include(x => x.Language)
                .Include(x => x.minimumAge)
                .FirstOrDefault();

            if (findLanguageAndMiniumAgeAndMovieInfo != null)
            {

                var FindMovieSchedules = _dataContext.movieSchedule.Where
                (x => x.movieId.Equals(findLanguageAndMiniumAgeAndMovieInfo.movieId));


                if (FindMovieSchedules.Count() == 0)
                {
                    var findGenreFilm = _dataContext.movieGenreInformation
                    .Where(x => x.movieId.Equals(movieID));


                    var findMovieVisualFormatID = _dataContext.movieVisualFormatDetails
                        .Where(x => x.movieId.Equals(movieID));

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

                    // Using ternary operator for strings
                    var Transition = await _dataContext.Database.BeginTransactionAsync();
                    try
                    {
                        movieName = string.IsNullOrEmpty(dtos.movieName) ? findLanguageAndMiniumAgeAndMovieInfo.movieName : dtos.movieName;
                        minumAgeID = string.IsNullOrEmpty(dtos.minimumAgeID) ? findLanguageAndMiniumAgeAndMovieInfo.minimumAgeID : dtos.minimumAgeID;
                        movieDescription = string.IsNullOrEmpty(dtos.movieDescription) ? findLanguageAndMiniumAgeAndMovieInfo.movieDescription : dtos.movieDescription;
                        movieDirector = string.IsNullOrEmpty(dtos.movieDirector) ? findLanguageAndMiniumAgeAndMovieInfo.movieDirector : dtos.movieDirector;
                        movieActor = string.IsNullOrEmpty(dtos.movieActor) ? findLanguageAndMiniumAgeAndMovieInfo.movieActor : dtos.movieActor;
                        trailerURL = string.IsNullOrEmpty(dtos.movieTrailerUrl) ? findLanguageAndMiniumAgeAndMovieInfo.movieTrailerUrl : dtos.movieTrailerUrl;
                        languageID = string.IsNullOrEmpty(dtos.languageId) ? findLanguageAndMiniumAgeAndMovieInfo.languageId : dtos.languageId;
                        movieImage = dtos.movieImage == null ?
                            findLanguageAndMiniumAgeAndMovieInfo.movieImage
                            :
                            await cloudinaryServices.uploadFileToCloudinary(dtos.movieImage);

                        movieDuration = dtos.movieDuration ?? findLanguageAndMiniumAgeAndMovieInfo.movieDuration;
                        relaseDate = dtos.releaseDate ?? findLanguageAndMiniumAgeAndMovieInfo.ReleaseDate;

                        // Nếu ko phải null thì tiến hành xóa hết trong DB

                        if (dtos.movieGenreList.IsNullOrEmpty())
                        {
                            _dataContext.movieGenreInformation
                                .RemoveRange(findGenreFilm);
                            movieGenreList = dtos.movieGenreList;
                        }

                        // Xóa hết

                        if (dtos.visualFormatList.IsNullOrEmpty())
                        {
                            _dataContext.movieVisualFormatDetails
                                .RemoveRange(findMovieVisualFormatID);
                            visualFormatList = dtos.visualFormatList;
                        }

                        findLanguageAndMiniumAgeAndMovieInfo.movieActor = movieActor;
                        findLanguageAndMiniumAgeAndMovieInfo.movieDirector = movieDirector;
                        findLanguageAndMiniumAgeAndMovieInfo.movieDuration = movieDuration;
                        findLanguageAndMiniumAgeAndMovieInfo.languageId = languageID;
                        findLanguageAndMiniumAgeAndMovieInfo.minimumAgeID = minumAgeID;
                        findLanguageAndMiniumAgeAndMovieInfo.movieName = movieName;
                        findLanguageAndMiniumAgeAndMovieInfo.ReleaseDate = relaseDate;
                        findLanguageAndMiniumAgeAndMovieInfo.movieDescription = movieDescription;
                        findLanguageAndMiniumAgeAndMovieInfo.movieImage = movieImage;


                        // Tạo một List chứa để CRUD vào DB

                        List<movieVisualFormatDetail> movieVisualFormatDetails = new List<movieVisualFormatDetail>();

                        List<movieGenreInformation> movieGenreInformation = new List<movieGenreInformation>();

                        foreach (var movieVisualID in visualFormatList)
                        {
                            movieVisualFormatDetails.Add
                                (new movieVisualFormatDetail()
                                {
                                    movieId = findLanguageAndMiniumAgeAndMovieInfo.movieId,
                                    movieVisualFormatId = movieVisualID,
                                });
                        }

                        foreach (var movieGenreID in movieGenreList)
                        {
                            movieGenreInformation.Add
                                (new movieGenreInformation()
                                {
                                    movieId = findLanguageAndMiniumAgeAndMovieInfo.movieId,
                                    movieGenreId = movieGenreID,
                                });
                        }

                        _dataContext.movieInformation.Update(findLanguageAndMiniumAgeAndMovieInfo);
                        await _dataContext.movieGenreInformation.AddRangeAsync(movieGenreInformation);
                        await _dataContext.movieVisualFormatDetails.AddRangeAsync(movieVisualFormatDetails);
                        await _dataContext.SaveChangesAsync();
                        await Transition.CommitAsync();
                        return true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        await Transition.RollbackAsync();
                        return false;
                    }
                }
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
