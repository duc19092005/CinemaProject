using backend.ModelDTO.Customer.OrderRequest;

namespace backend.Interface.BookingInterface
{
    public interface IBookingServices
    {
        Task<bool> booking(OrderRequestDTO orderRequestDTO);
    }
}
