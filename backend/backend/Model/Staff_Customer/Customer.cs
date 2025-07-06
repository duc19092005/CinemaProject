using backend.BaseModel.BaseModel_UserInformation;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.Movie;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Staff_Customer
{
    public class Customer : BaseModel_Customer_Staff
    {

        [ForeignKey("userInformation")]
        public string userID { get; set; } = string.Empty;

        public userInformation userInformation { get; set; } = null!;

        public List<Order> Order { get; set; } = [];

        public List<movieCommentDetail> movieCommentDetail { get; set; } = [];
    }
}
