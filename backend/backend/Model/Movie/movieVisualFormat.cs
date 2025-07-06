using backend.Model.CinemaRoom;
using backend.Model.Price;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Movie
{
    [Index(nameof(movieVisualFormatName) , IsUnique = true)]
    public class movieVisualFormat
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string movieVisualFormatId { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string movieVisualFormatName { get; set; } = "";

        // MQH N_N
        public List<movieVisualFormatDetail> movieVisualFormatDetail { get; set; } = [];

        public List<priceInformationForEachUserFilmType> priceInformation { get; set; } = [];

        public List<movieSchedule> movieSchedule { get; set; } = [];

        public List<cinemaRoom> cinemaRoom { get; set; } = [];

    }
}
