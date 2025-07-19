using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.BaseModel.BaseModel_UserInformation
{
    public class BaseModel_Customer_Staff
    {
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime dateOfBirth { get; set; }

        // Số điện thoại của User
        // Chỉ được có 10 chữ số

        [Column(TypeName = "varchar(10)")]
        [Required]
        public string phoneNumber { get; set; } = "";

    }
}
