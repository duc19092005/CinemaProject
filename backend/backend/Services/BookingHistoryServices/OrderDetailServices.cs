using backend.Interface;
using backend.Interface.Customter;
using backend.Data;
using Microsoft.EntityFrameworkCore;
using backend.ModelDTO.BookingHistoryDTO.OrderDetailRespond;

namespace backend.Services.BookingHistoryServices
{
    public class OrderDetailServices : IOrderDetail
    {
        private readonly DataContext _dataContext;

        public OrderDetailServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public OrderDetailRespond GetOrderDetailRespond(string orderID)
        {
            var getOrderTicket = _dataContext.TicketOrderDetail.Where(x => x.orderId.Equals(orderID)).ToList();
            var getOrderFood = _dataContext.FoodOrderDetail.Where(x => x.orderId.Equals(orderID)).Include(x => x.foodInformation).ToList();

            var orderDetailRespond = new OrderDetailRespond()
            {
                orderId = orderID,
                DetailTickets = getOrderTicket,
                DetailFoods = getOrderFood
            };

            return orderDetailRespond;
        }
    }
}
