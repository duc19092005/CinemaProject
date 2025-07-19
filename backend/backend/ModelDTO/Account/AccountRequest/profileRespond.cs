using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.Account.AccountRequest
{
    public class ProfileRespond
    {
        // Trả về ID user
        public string CustomerId { get; set; } = "";

        // Ngày tháng năm sinh của user

        public DateTime DayOfBirth { get; set; }


        public string PhoneNumber { get; set; } = "";

        // Tên của user khi mua vé

        public string UserName { get; set; } = "";
        
        public string IdentityCode { get; set; } = "";
    }
}
