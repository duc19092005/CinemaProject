using backend.Data;
using backend.Interface.CommentInterface;
using backend.Interface.MovieInterface;
using backend.ModelDTO.CommentDTO.CommentRespond;
using Microsoft.AspNetCore.Http.Features;

namespace backend.Services.MovieServices
{
    public class CommentServices : ICommentServices
    {
        private readonly DataContext _dataContext;

        public CommentServices(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public List<CommentRespondDTO> getAllComent(string movieID)
        {
            // Ai biết sửa cái warning này sửa giúp tui với :(
            if (movieID != null)
            {
                var getComment = _dataContext.movieCommentDetail.Where(x => x.movieId.Equals(movieID)).ToList();
                var newListCommentRespond = new List<CommentRespondDTO>();
                foreach (var item in getComment)
                {
                    var newComment = new CommentRespondDTO()
                    {
                        commentDetail = item.userCommentDetail,
                        loginUserName = _dataContext.userInformation.FirstOrDefault
                        (x => x.userId.Equals
                        (_dataContext.Customers.FirstOrDefault(x => x.Id.Equals(item.customerID)).userID)) ? .loginUserEmail ?? "UnknownUser"
                    };
                    newListCommentRespond.Add(newComment);
                }
                return newListCommentRespond;
            }
            return null!;
        }
    }
}
