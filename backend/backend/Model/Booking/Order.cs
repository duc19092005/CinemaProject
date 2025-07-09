using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;
using backend.Model.Staff_Customer;

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
        public string PaymentStatus { get; set; } = string.Empty;

        [Required]
        public long totalAmount { get; set; }

        public DateTime paymentRequestCreatedDate { get; set; }

        [Column(TypeName = "varchar(100)")]
        [ForeignKey("Customer")]
        [Required]
        public string customerID { get; set; } = "";

        public Customer Customer { get; set; } = null!;

        public List<orderDetailTicket> orderDetail = [];

        public List<orderDetailFood> orderDetailFood = [];

        
    }
}
