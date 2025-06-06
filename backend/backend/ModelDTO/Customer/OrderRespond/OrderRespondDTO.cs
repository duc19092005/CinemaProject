using backend.Model.Auth;
using backend.Model.Booking;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.Customer.OrderRespond
{
    public class OrderRespondDTO
    {
        public string userName { get; set; } = "";

        public string IdentityCode { get; set; } = "";

        public int userPoint { get; set; }

        public List<Order> GetOrders = [];

    }
}
