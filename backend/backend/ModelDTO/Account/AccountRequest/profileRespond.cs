using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.Account.AccountRequest
{
    public class profileRespond
    {
        // Trả về ID user
        public string userId { get; set; } = "";

        // Ngày tháng năm sinh của user

        public DateTime dateOfBirth { get; set; }


        public string phoneNumber { get; set; } = "";

        // Tên của user khi mua vé

        public string userName { get; set; } = "";

        public int userPoint { get; set; }

        // quyền hạn của User

        public List<userRoleInformation> userRoleInformation { get; set; } = [];
    }
}
