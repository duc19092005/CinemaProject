using backend.Model.Price;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Movie
{
    public class movieVisualFormat
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string movieVisualFormatId { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string movieVisualFormatName { get; set; } = "";

        public List<movieInformation> movieInformation { get; set; } = [];

        public List<priceInformation> priceInformation { get; set; } = [];
    }
}
