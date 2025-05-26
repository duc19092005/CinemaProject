using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.Auth
{
    public class userInformationDTO
    {
       
        public string loginUserName { get; set; } = "";

        // Mật khẩu của một user

   
        public string loginUserPassword { get; set; } = "";

        public IFormFile userImage { get; set; } = null!;



        public DateTime dateOfBirth { get; set; }

        // Số điện thoại của User
        // Chỉ được có 10 chữ số

  
        public string phoneNumber { get; set; } = "";

        // Tên của user khi mua vé

        public string userName { get; set; } = "";

        // Số CCCD để khi mua vé để thu ngân check vé


    
        public string IdentityCode { get; set; } = "";

        public int userPoint { get; set; }
    }
}
