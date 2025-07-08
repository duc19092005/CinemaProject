using backend.ModelDTO.CommentDTO.CommentRespond;

namespace backend.Interface.CommentInterface
{
    public interface ICommentServices
    {
        List<CommentRespondDTO> getAllComent(string movieID);
    }
}
