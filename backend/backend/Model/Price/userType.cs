using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;

namespace backend.Model.Price
{
    public class userType
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string userTypeId { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string userTypeDescription { get; set; } = "";

        public List<priceInformationForEachUserFilmType> priceInformation { get; set; } = null!;


    }
}
