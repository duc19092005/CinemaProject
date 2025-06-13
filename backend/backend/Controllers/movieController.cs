using backend.Interface.ManagerInterface.ContentManager;
using backend.ModelDTO.ContentManagement.MovieRequest;
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
            if (postMovie)
            {
                return Ok(postMovie);
            }
            return NotFound();
        }
    }
}
