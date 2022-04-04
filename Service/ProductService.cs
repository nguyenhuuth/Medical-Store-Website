using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils;
using System.Collections.Generic;
using MedicalStore.Utils.Interface;

namespace MedicalStore.Service
{
    public class ProductService : IProductService
    {
        private readonly DBContext DBContext;
        private readonly IProductRepository ProductRepository;

        public ProductService(DBContext dBContext, IProductRepository productRepository)
        {
            this.DBContext = dBContext;
            ProductRepository = productRepository;
        }
        public Product GetProductById(string productId)
        {
            return this.ProductRepository.GetProductById(productId);
        }


        public bool CreateProductHandler(Product product)
        {
            return this.ProductRepository.InsertHandler(product);
        }

        public bool UpdateProductHandler(Product product)
        {
            return this.ProductRepository.UpdateHandler(product);
        }

        public (List<Product>, int) GetListProductByShopId(string shopId, int pageIndex, int pageSize)
        {
            return this.ProductRepository.GetListProductByShopId(shopId, pageIndex, pageSize);
        }

        public Product GetProductByName(string name)
        {
            return this.ProductRepository.GetProductByName(name);
        }

        public (List<Product>, int) GetProducts(int pageIndex, int pageSize, double min, double max, string name, string categoryId, CategoryStatus categoryStatus)
        {
            return this.ProductRepository.GetProducts(pageIndex, pageSize, min, max, name, categoryId, categoryStatus);
        }

        public List<Product> GetListProductByCategoryId(string categoryId)
        {
            return this.ProductRepository.GetListProductByCategoryId(categoryId);
        }

        public List<Product> GetAllProduct()
        {
            return this.ProductRepository.GetAllProduct();
        }

        public (List<Product>, int) GetProductForManage(string shopName, string productName, string categoryId, int pageIndex, int pageSize)
        {
            return this.ProductRepository.GetProductForManage(shopName, productName, categoryId, pageIndex, pageSize);
        }
    }
}
