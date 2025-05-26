using System.ComponentModel.DataAnnotations;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;

namespace backend.Model.Product
{
    public class foodInformation
    {
        [Key]
        public string foodInformationId { get; set; } = "";

        [Required]
        public string foodInformationName { get; set; } = "";

        [Required]
        public long foodPrice { get; set; }

        public List<orderDetailFood> orderDetailFood = [];
    }
}
