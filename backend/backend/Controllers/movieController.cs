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
            
            await IMovieService.SaveChanges();
            if (createdStatus)
            {
                return Ok(new { message = "Đã thêm thành công", statusCode = StatusCodes.Status201Created });
            }
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            return BadRequest(new { message = "Đã thêm thất bại", statusCode = StatusCodes.Status400BadRequest });
        }

        [HttpPatch("editMovie")]
        public async Task<IActionResult> editMovie(string movieID , [FromForm] MovieEditRequestDTO dtos)
        {
            var status = await IMovieService.edit(movieID, dtos);
            if (status)
            {
                return Ok(new { message = "Đã sửa thành công", statusCode = StatusCodes.Status200OK });
            }
            return BadRequest(new { message = "Đã sửa thất bại", statusCode = StatusCodes.Status400BadRequest });
        }

        [HttpGet("getMovieDetail")]
        public IActionResult getMovieDetail(string movieID)
        {
            var getMovieDetail = IMovieService.getMovieDetail(movieID);
            if (getMovieDetail.Status.Equals(GenericStatusEnum.Success.ToString()))
            {
                return Ok(getMovieDetail);
            }
            return BadRequest(getMovieDetail);
        }

        [HttpDelete("DeleteMovie")]
        public async Task<IActionResult> deleteMovie(string Id)
        {
            try
            {
                var deleteStatus = await IMovieService.remove(Id);
                if (deleteStatus)
                {
                    await IMovieService.SaveChanges();
                    return Ok(new { message = "đã xóa thành công", StatusCode = StatusCodes.Status200OK });
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message);  }
            return BadRequest(new { message = "đã xóa thất bại", StatusCode = StatusCodes.Status404NotFound });
        }

        [HttpGet("getAllMoviesPagniation")]
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
    }
}
