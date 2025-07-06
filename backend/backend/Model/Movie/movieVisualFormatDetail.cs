using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace backend.Model.Movie
{
    public partial class movieVisualFormatDetail
    {
        [ForeignKey("movieInformation")]
        [Column(TypeName = "varchar(100)")]
        public string movieId { get; set; } = "";

        [ForeignKey("movieVisualFormat")]
        [Column(TypeName = "varchar(100)")]
        public string movieVisualFormatId { get; set; } = "";

        public movieVisualFormat movieVisualFormat { get; set; } = null!;

        public movieInformation movieInformation { get; set; } = null!;
    }

    [PrimaryKey(nameof(movieId) , nameof(movieVisualFormatId))]
    public partial class movieVisualFormatDetail
    {

    }
}
