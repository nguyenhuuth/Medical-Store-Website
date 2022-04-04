using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using System.Collections.Generic;
using System.Linq;

namespace MedicalStore.DAO
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly DBContext DBContext;
        private readonly IProductRepository ProductRepository;
        public OrderItemRepository(DBContext dBContext, IProductRepository productRepository)
        {
            this.DBContext = dBContext;
            this.ProductRepository = productRepository;
        }

        public List<OrderItem> GetAllOrderItemByOrderId(string orderId)
        {
            List<OrderItem> listOrderItem = this.DBContext.OrderItem.Where<OrderItem>(item => item.OrderId == orderId).ToList<OrderItem>();
            return listOrderItem;
        }

        public List<OrderItem> GetAllOrderItemByProductId(string productId)
        {
            List<OrderItem> listOrderItem = this.DBContext.OrderItem.Where<OrderItem>(item => item.ProductId == productId).ToList<OrderItem>();
            return listOrderItem;
        }
    }
}
