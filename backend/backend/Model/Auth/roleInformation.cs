using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Auth
{
    public class roleInformation
    {

        // ID của Role 


        [Key]
        [Column(TypeName = "varchar(100)")]
        public string roleId { get; set; } = "";


        // Chi tiết có những Role gì trong hệ thống

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string roleName { get; set; } = "";

        public List<userRoleInformation> userRoleInformation { get; set; } = [];

    }
}
