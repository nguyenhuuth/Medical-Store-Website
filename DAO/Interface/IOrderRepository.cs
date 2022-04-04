using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface IOrderRepository
    {
        public (List<Order>, int) GetOrders(string startDate, string endDate, string userId, int pageIndex, int pageSize);
        public (List<OrderItem>, int) GetOrderDetail(string orderId, int pageIndex, int pageSize);
        public (List<Order>, int) SearchOrders(string startDate, string endDate, string search, int pageIndex, int pageSize, string shopId);
        public bool CreateOrderHandler(Order order);
        public bool CreateOrderItemHandler(OrderItem orderItem);
        public Order GetOrderByOrderId(string orderId);
        public List<Order> GetlistSoldOrder(string shopId);
        public List<Order> GetOrdersHistory(string customerId);

    }
}
