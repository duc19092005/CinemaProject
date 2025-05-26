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
    public class priceInformation
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string priceInformationId { get; set; } = "";

        [Required]
        public long priceAmount { get; set; }


        [Column(TypeName = "varchar(100)")]
        [ForeignKey("userType")]
        public string userTypeId { get; set; } = "";

        public userType userType { get; set; } = null!;

        public List<orderDetailTicket> orderDetail = [];

    }
}
