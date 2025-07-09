using backend.ModelDTO.Customer.OrderRequest;

namespace backend.Interface.BookingInterface
{
    public interface IBookingServices
    {
        Task<string> booking(OrderRequestDTO orderRequestDTO , HttpContext httpContext);
    }
}
