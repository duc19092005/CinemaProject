using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;

namespace backend.Model.Booking
{
    public class Order
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string orderId { get; set; } = "";

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string paymentMethod { get; set; } = "VNPAY";

        [Required]
        public bool isPay { get; set; } = false;

        [Required]
        public long totalAmount { get; set; }

        public DateTime paymentDate { get; set; }

        [Column(TypeName = "varchar(100)")]
        [ForeignKey("userInformation")]
        [Required]
        public string userId { get; set; } = "";

        public userInformation userInformation { get; set; } = null!;

        public List<orderDetailTicket> orderDetail = [];

        public List<orderDetailFood> orderDetailFood = [];

        
    }
}
