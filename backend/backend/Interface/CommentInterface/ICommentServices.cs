using backend.Enum;
using backend.ModelDTO.CommentDTO.CommentRequest;
using backend.ModelDTO.CommentDTO.CommentRespond;
using backend.ModelDTO.GenericRespond;

namespace backend.Interface.CommentInterface
{
    public interface ICommentServices
    {
        List<CommentRequestGetListDTO> getAllComent(string movieID);

        GenericRespondWithObjectDTO<CommentRequestDTO> getCommentDetails(string commentID);

        Task<GenericRespondDTOs> uploadComment(string userID, string movieID, CommentRequestDTO commentRequestDTO);

        Task<GenericRespondDTOs> editComment(string commentID, CommentRequestDTO commentRequestDTO);

        Task<GenericRespondDTOs> deleteComment(string commentID);
    }
}
