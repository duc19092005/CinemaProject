using backend.Interface.MovieInterfaces;
using backend.ModelDTO.MoviesDTO.MovieRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class movieController : ControllerBase
    {
        private readonly IMovie _Imovie;

        public movieController(IMovie _Imovie)
        {
            this._Imovie = _Imovie; 
        }

        [HttpPost("createMovie")]
        public async Task<IActionResult> createMovie([FromForm] MovieRequestDTO movieRequestDTO) 
        { 
            var postMovie = await _Imovie.uploadMovie(movieRequestDTO);
            var getStatus = HttpContext.Response.StatusCode;
            if (postMovie)
            {
                return Ok(new {message = "Đã thêm thành công" , Status = getStatus });
            }
            return NotFound(new {message = "Đã thêm thất bại" , Status = getStatus});
        }
    }
}
