using backend.ModelDTO.BookingHistoryDTO.OrderDetailRespond;

namespace backend.Interface.Customter
{
    public interface IOrderDetail
    {
        OrderDetailRespond GetOrderDetailRespond(string orderID);
    }
}
