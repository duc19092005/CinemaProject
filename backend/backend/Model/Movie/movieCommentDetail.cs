
using backend.Model.Auth;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Movie
{
    public partial class movieCommentDetail
    {
        [ForeignKey("movieInformation")]
        [Column(TypeName = "varchar(100)")]
        public string movieId { get; set; } = string.Empty;

        [ForeignKey("userInformation")]
        [Column(TypeName = "varchar(100)")]
        public string userId { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(200)")]
        public string userCommentDetail {  get; set; } = string.Empty;

        public movieInformation movieInformation { get; set; } = null!;

        public userInformation userInformation { get; set; } = null!;
    }

    [PrimaryKey(nameof(movieId) , nameof(userId))]
    public partial class movieCommentDetail
    {

    }
}
