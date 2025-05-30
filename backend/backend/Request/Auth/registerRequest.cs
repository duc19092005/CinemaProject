using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Request.Auth
{
    public class registerRequest
    {
        [Required(ErrorMessage = "Email không được để trống.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
                           ErrorMessage = "Địa chỉ email không đúng định dạng. Email phải có ký tự '@'.")]
        public string loginEmail { get; set; } = "";

        // Mật khẩu của một user

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu ít nhất phải 8 ký tự")]
        public string loginUserPassword { get; set; } = "";

        // Xử lý bên backend
        // Nhập lại mật khẩu

        [Required(ErrorMessage = "Không được để trống")]
        [Compare("loginUserPassword", ErrorMessage = "Mật khẩu không khớp")]
        public string reLoginUserPassword { get; set; } = "";

        // Ngày tháng năm sinh của user

        [Required(ErrorMessage = "Không được để trống")]
        public DateTime dateOfBirth { get; set; }

        // Số điện thoại của User
        // Chỉ được có 10 chữ số

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Số điện thoại phải có đúng 10 chữ số.")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Số điện thoại chỉ được chứa các chữ số và phải có đúng 10 chữ số.")]
        public string phoneNumber { get; set; } = "";

        // Tên của user khi mua vé

        [Required(ErrorMessage = "Không được để trống")]
        public string userName { get; set; } = "";

        // Số CCCD để khi mua vé để thu ngân check vé


        [Required(ErrorMessage = "Không được để trống")]
        public string IdentityCode { get; set; } = "";
    }
}
