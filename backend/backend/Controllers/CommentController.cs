using backend.Interface.CommentInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentServices _services;

        public CommentController(ICommentServices services)
        {
            _services = services;
        }

        [HttpGet("getComment/{movieID}")]
        [AllowAnonymous]
        public IActionResult getCommentList(string movieID)
        {
            var ListComment = _services.getAllComent(movieID);
            if (ListComment.Count > 0)
            {
                return Ok(ListComment);
            }
            return BadRequest(new {message = "Phim hiện tại chưa có comment :("});
        }
    }
}
