using backend.Interface.GenericsInterface;
using backend.ModelDTO.MoviesDTO.MovieRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class movieController : ControllerBase
    {
        private readonly GenericInterface<MovieRequestDTO> _genericInterface;

        private readonly HttpContext _httpContext;

        public movieController(GenericInterface<MovieRequestDTO> _genericInterface , HttpContext httpContext)
        {
            this._genericInterface = _genericInterface;
            this._httpContext = httpContext;
        }

        [HttpPost("createMovie")]
        public async Task<IActionResult> createMovie([FromForm] MovieRequestDTO movieRequestDTO) 
        {
            var createdStatus = await _genericInterface.add(movieRequestDTO);
            if (createdStatus)
            {
                _httpContext.Response.StatusCode = StatusCodes.Status200OK;
                return Ok(new { message = "Đã thêm thành công", statusCode = _httpContext.Response.StatusCode });
            }
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            return BadRequest(new { message = "Đã thêm thất bại", statusCode = _httpContext.Response.StatusCode });
        }
    }
}
