using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using MedicalStore.Utils.Interface;
using System.Collections.Generic;

namespace MedicalStore.DAO
{
    public class OrderItemService : IOrderItemService
    {
        private readonly DBContext DBContext;
        private readonly IOrderItemRepository OrderItemRepository;

        public OrderItemService(DBContext dBContext, IOrderItemRepository orderItemRepository)
        {
            this.DBContext = dBContext;
            this.OrderItemRepository = orderItemRepository;
        }

        public List<OrderItem> GetAllOrderItemByOrderId(string orderId)
        {
            return this.OrderItemRepository.GetAllOrderItemByOrderId(orderId);
        }

        public List<OrderItem> GetAllOrderItemByProductId(string productId)
        {
            return this.OrderItemRepository.GetAllOrderItemByProductId(productId);
        }
    }
}
