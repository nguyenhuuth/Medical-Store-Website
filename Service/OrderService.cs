using MedicalStore.DAO.Interface;
using MedicalStore.Service.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using MedicalStore.Utils.Interface;
using System.Collections.Generic;

namespace MedicalStore.DAO
{
    public class OrderService : IOrderService
    {
        private readonly DBContext DBContext;
        private readonly IOrderRepository OrderRepository;
        private readonly ICartService CartService;
        public OrderService(ICartService cartService, DBContext dBContext, IOrderRepository orderRepository)
        {
            this.DBContext = dBContext;
            this.OrderRepository = orderRepository;
            this.CartService = cartService;
        }

        public (List<Order>, int) GetOrders(string startDate, string endDate, string userId, int pageIndex, int pageSize)
        {
            return this.OrderRepository.GetOrders(startDate, endDate, userId, pageIndex, pageSize);
        }
        public (List<OrderItem>, int) GetOrderDetail(string orderId, int pageIndex, int pageSize)
        {
            return this.OrderRepository.GetOrderDetail(orderId, pageIndex, pageSize);
        }
        public (List<Order>, int) SearchOrders(string startDate, string endDate, string search, int pageIndex, int pageSize, string shopId)
        {
            return this.OrderRepository.SearchOrders(startDate, endDate, search, pageIndex, pageSize, shopId);
        }

        public bool CreateOrderHandler(Order order)
        {
            return this.OrderRepository.CreateOrderHandler(order);
        }

        public bool CreateOrderItemHandler(OrderItem orderItem)
        {
            return this.OrderRepository.CreateOrderItemHandler(orderItem);
        }

        public Order GetOrderByOrderId(string orderId)
        {
            return this.OrderRepository.GetOrderByOrderId(orderId);
        }


        public List<Order> GetlistSoldOrder(string shopId)
        {
            return this.OrderRepository.GetlistSoldOrder(shopId);
        }

        public List<Order> GetOrdersHistory(string customerId)
        {
            return this.OrderRepository.GetOrdersHistory(customerId);
        }

    }
}
