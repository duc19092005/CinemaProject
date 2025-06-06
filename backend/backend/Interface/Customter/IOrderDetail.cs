using backend.ModelDTO.Customer.OrderDetailRespond;

namespace backend.Interface.Customter
{
    public interface IOrderDetail
    {
        OrderDetailRespond GetOrderDetailRespond(string orderID);
    }
}
