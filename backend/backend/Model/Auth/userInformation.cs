using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Booking;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Staff_Customer;
using Microsoft.EntityFrameworkCore;

namespace backend.Model.Auth
{
    [Index(nameof(loginUserEmail) , IsUnique = true)]
    public class userInformation
    {
        // ID của User trong DB 

        [Key]
        [Column(TypeName = "varchar(100)")]
        public string userId { get; set; } = "";

        // Tên đăng nhập của một user

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string loginUserEmail { get; set; } = "";

        // Mật khẩu của một user

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string loginUserPassword { get; set; } = "";

        public List<userRoleInformation> userRoleInformation { get; set; } = [];

        public Customer Customer { get; set; } = null!;

        public Staff Staff { get; set; } = null!;
    }
}
