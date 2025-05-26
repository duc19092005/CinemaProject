using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Booking;

namespace backend.Model.Auth
{
    public class userInformation
    {
        // ID của User trong DB 

        [Key]
        [Column(TypeName = "varchar(100)")]
        public string userId { get; set; } = "";

        public byte[] userImage { get; set; } = [];


        // Tên đăng nhập của một user

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string loginUserName { get; set; } = "";

        // Mật khẩu của một user

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string loginUserPassword { get; set; } = "";

        // Ngày tháng năm sinh của user

        [Required]
        public DateTime dateOfBirth { get; set; }

        // Số điện thoại của User
        // Chỉ được có 10 chữ số

        [Column(TypeName = "varchar(10)")]
        [Required]
        public string phoneNumber { get; set; } = "";

        // Tên của user khi mua vé

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string userName { get; set; } = "";

        // Số CCCD để khi mua vé để thu ngân check vé


        [Column(TypeName = "varchar(12)")]
        [Required]
        public string IdentityCode { get; set; } = "";

        [Required]
        public int userPoint { get; set; }

        public List<userRoleInformation> userRoleInformation { get; set; } = [];

        public List<Order> Order { get; set; } = [];
    }
}
