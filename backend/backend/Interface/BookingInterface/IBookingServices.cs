using backend.ModelDTO.Customer.OrderRequest;
using backend.ModelDTO.Customer.OrderRespond;

namespace backend.Interface.BookingInterface
{
    public interface IBookingServices
    {
        Task<OrderRespondDTO> booking(OrderRequestDTO orderRequestDTO , HttpContext httpContext);
    }
}
