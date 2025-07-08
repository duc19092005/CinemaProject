using backend.BaseModel.BaseModel_UserInformation;
using backend.Model.Auth;
using backend.Model.Cinemas;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Staff_Customer
{
    public class Staff : BaseModel_Customer_Staff
    {

        [ForeignKey("Cinema")]
        public string cinemaID { get; set; } = string.Empty;

        [ForeignKey("userInformation")]
        public string userID { get; set; } = string.Empty;

        public userInformation userInformation { get; set; } = null!;

        // Một nhân viên làm ở nhiều rạp
        public Cinema Cinema { get; set; } = null!;

    }
}
