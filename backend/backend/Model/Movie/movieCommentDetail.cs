
using backend.Model.Auth;
using backend.Model.Staff_Customer;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Movie
{
    public partial class movieCommentDetail
    {
        [Key]
        public string commentID { get; set; } = string.Empty;
        [ForeignKey("movieInformation")]
        [Column(TypeName = "varchar(100)")]
        public string movieId { get; set; } = string.Empty;

        [ForeignKey("Customer")]
        [Column(TypeName = "varchar(100)")]
        public string customerID { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(200)")]
        public string userCommentDetail {  get; set; } = string.Empty;

        public DateTime createdCommentTime { get; set; }

        public movieInformation movieInformation { get; set; } = null!;

        public Customer Customer { get; set; } = null!;
    }
}
