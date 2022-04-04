using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface IProductRepository
    {
        public Product GetProductByName(string name);
        public Product GetProductById(string id);
        public bool InsertHandler(Product product);
        public bool UpdateHandler(Product product);
        public (List<Product>, int) GetListProductByShopId(string shopId, int pageIndex, int pageSize);
        public (List<Product>, int) GetProducts(int pageIndex, int pageSize, double min, double max, string name, string categoryId, CategoryStatus categoryStatus);
        public List<Product> GetListProductByCategoryId(string categoryId);
        public List<Product> GetAllProduct();
        public (List<Product>, int) GetProductForManage(string shopName, string productName, string categoryId, int pageIndex, int pageSize);
    }
}
