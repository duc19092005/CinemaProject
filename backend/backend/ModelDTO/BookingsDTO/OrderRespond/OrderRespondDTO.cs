using backend.Model.Auth;
using backend.Model.Booking;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.Customer.OrderRespond
{
    public class OrderRespondDTO
    {
        public string? Error { get; set; }

        public string ? VnpayURL { get; set; } 

        public long TotalAmount { get; set; } 
    }
}
