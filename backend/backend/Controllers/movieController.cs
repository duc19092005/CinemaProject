using backend.Interface.GenericsInterface;
using backend.ModelDTO.MoviesDTO.MovieRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BCrypt.Net;
using backend.Interface.MovieInterface;
using Microsoft.AspNetCore.Authorization;
using backend.Enum;
namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class movieController : ControllerBase
    {
        private readonly IMovieService IMovieService;

        public movieController(IMovieService IMovieService)
        {
            this.IMovieService = IMovieService;
        }

        [HttpPost("createMovie")]
        public async Task<IActionResult> createMovie([FromForm] MovieRequestDTO movieRequestDTO) 
        {
            var createdStatus = await IMovieService.add(movieRequestDTO);
            
            if (createdStatus.Status.ToLower().StartsWith("f"))
            {
                return BadRequest(new { ThongTinLoi = createdStatus});
            }
            return Created();
        }

        [HttpPatch("editMovie/{movieID}")]
        public async Task<IActionResult> editMovie(string movieID , [FromForm] MovieEditRequestDTO dtos)
        {
            var status = await IMovieService.edit(movieID, dtos);
            if (status.Status.ToLower().StartsWith("f"))
            {
                return BadRequest(new { ThongTinLoi = status });
            }
            return Ok(new { ThongBao = status });
        }

        [HttpGet("getMovieDetail/{movieID}")]
        public IActionResult getMovieDetail(string movieID)
        {
            var getMovieDetail = IMovieService.getMovieDetail(movieID);
            if (getMovieDetail.Status.Equals(GenericStatusEnum.Success.ToString()))
            {
                return Ok(getMovieDetail);
            }
            return BadRequest(getMovieDetail);
        }

        [HttpDelete("DeleteMovie/{Id}")]
        public async Task<IActionResult> deleteMovie(string Id)
        {
            var deleteStatus = await IMovieService.remove(Id);
            try
            {
                if (deleteStatus.Status.Equals(GenericStatusEnum.Failure.ToString()))
                {
                    return BadRequest(new { message = deleteStatus });
                }
                await IMovieService.SaveChanges();
                return Ok(new { message = deleteStatus });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = deleteStatus });
            }
        }

        [HttpGet("getAllMoviesPagniation/{page}")]
        public async Task<IActionResult> getAllMoviesPagniation(int page)
        {
            if (page <= 0)
            {
                return NotFound("Sorry Page not found");
            }

            var getitemsList = await IMovieService.getListItemsPagination(page);
            if (getitemsList != null)
            {
                return Ok(getitemsList);
            }
            return NotFound(new { message = "Cannot Find Movie There's an error" });
        }
        
        [HttpGet("SearchMovieTake5")]
        public async Task<IActionResult> SearchMovieTake5(string movieName)
        {
            var gettersList = await IMovieService.getListMoviesByNameTake5(movieName);
            if (gettersList.Count > 0)
            {
                return Ok(gettersList);
            }
            return NotFound(new { message = "Cannot Find Movie There's an error" });
        }
        
        [HttpGet("SearchAllMovie")]
        public async Task<IActionResult> SearchMovieTake5(string movieName , int page)
        {
            var gettersList = await IMovieService.getFullSearchResult(movieName , page);
            return Ok(gettersList);
        }
    }
}
