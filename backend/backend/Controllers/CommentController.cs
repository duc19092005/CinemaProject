using backend.Enum;
using backend.Interface.CommentInterface;
using backend.ModelDTO.CommentDTO.CommentRequest;
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

        [HttpPost("uploadComment/{CustomerID}/{movieID}")]
        public async Task<IActionResult> postComment(string CustomerID , string movieID , CommentRequestDTO dtos)
        {
            var getStatus = await _services.uploadComment(CustomerID, movieID, dtos);
            if (getStatus.message.ToLower().Contains("lỗi"))
            {
                return BadRequest(getStatus);
            }
            return Ok(getStatus);
        }

        [HttpPatch("editComment/{commentID}")]
        public async Task<IActionResult> editComment(string commentID, CommentRequestDTO dtos)
        {
            var getStatus = await _services.editComment(commentID, dtos);
            if (getStatus.Status.Equals(GenericStatusEnum.Failure.ToString()))
            {
                return NotFound(getStatus);
            }
            return Ok(getStatus);
        }

        [HttpDelete("deleteComment/{commentID}")]
        public async Task<IActionResult> deleteComment(string commentID)
        {
            var getStatus = await _services.deleteComment(commentID);
            if (getStatus.Status.Equals(GenericStatusEnum.Failure.ToString()))
            {
                return NotFound(getStatus);
            }
            return Ok(getStatus);
        }
    }
}
