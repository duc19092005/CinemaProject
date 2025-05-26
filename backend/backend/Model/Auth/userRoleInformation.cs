using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Auth
{
    // Bảng này được tạo ra mục đích là chỉ ra mối quan hệ nhiều nhiều

    public partial class userRoleInformation
    {
        // ID của user

        [ForeignKey("userInformation")]
        [Column(TypeName = "varchar(100)")]
        public string userId { get; set; } = "";

        // Role của User

        [ForeignKey("roleInformation")]
        [Column(TypeName = "varchar(100)")]
        public string roleId { get; set; } = "";

        public userInformation userInformation { get; set; } = null!;

        public roleInformation roleInformation { get; set; } = null!;

    }

    [PrimaryKey(nameof(roleId), nameof(userId))]
    public partial class userRoleInformation
    {

    }
}
