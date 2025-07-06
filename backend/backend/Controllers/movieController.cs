using backend.Interface.GenericsInterface;
using backend.ModelDTO.MoviesDTO.MovieRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BCrypt.Net;
using backend.Interface.MovieInterface;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Policy = "Customer")]
        [HttpPost("createMovie")]
        public async Task<IActionResult> createMovie([FromForm] MovieRequestDTO movieRequestDTO) 
        {
            var createdStatus = await IMovieService.add(movieRequestDTO);
            
            await IMovieService.SaveChanges();
            if (createdStatus)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return Ok(new { message = "Đã thêm thành công", statusCode = HttpContext.Response.StatusCode });
            }
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            return BadRequest(new { message = "Đã thêm thất bại", statusCode = HttpContext.Response.StatusCode });
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
