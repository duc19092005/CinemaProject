using backend.Enum;
using backend.ModelDTO.CommentDTO.CommentRequest;
using backend.ModelDTO.CommentDTO.CommentRespond;
using backend.ModelDTO.GenericRespond;

namespace backend.Interface.CommentInterface
{
    public interface ICommentServices
    {
        List<CommentRequestGetListDTO> getAllComent(string movieID);

        Task<GenericRespondDTOs> uploadComment(string userID, string movieID, CommentRequestDTO commentRequestDTO);

        GenericRespondDTOs editComment(string userID, string movieID, CommentRequestDTO commentRequestDTO);

        GenericRespondDTOs deleteComment(string userID, string movieID); 
    }
}
