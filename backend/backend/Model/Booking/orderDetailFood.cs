using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Booking
{
    public partial class orderDetailFood
    {
        [Required]
        [ForeignKey("Order")]
        public string orderId { get; set; } = "";

        [Required]
        [ForeignKey("foodInformation")]
        public string foodInformationId { get; set; } = "";

        public int quanlity { get; set; }
        public Order Order { get; set; } = null!;

        public foodInformation foodInformation { get; set; } = null!;
    }

    [PrimaryKey(nameof(orderId) , nameof(foodInformationId))]
    public partial class orderDetailFood
    {

    }
}
