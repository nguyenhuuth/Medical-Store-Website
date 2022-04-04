using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using System.Collections.Generic;
using System.Linq;

namespace MedicalStore.DAO
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBContext DBContext;
        private readonly IUserRepository UserRepository;

        public ProductRepository(DBContext dBContext, IUserRepository userRepository)
        {
            this.DBContext = dBContext;
            this.UserRepository = userRepository;
        }
        public Product GetProductById(string id)
        {
            Product product = this.DBContext.Product.FirstOrDefault(item => item.ProductId == id);
            return product;
        }

        public Product GetProductByName(string name)
        {
            Product product = this.DBContext.Product.FirstOrDefault(item => item.Name == name);
            return product;
        }

        public bool InsertHandler(Product product)
        {
            this.DBContext.Product.Add(product);
            return this.DBContext.SaveChanges() > 0;
        }

        public bool UpdateHandler(Product product)
        {
            this.DBContext.Product.Update(product);
            return this.DBContext.SaveChanges() >0;
        }

        public (List<Product>, int) GetListProductByShopId(string shopId, int pageIndex, int pageSize)
        {
            List<Product> products = this.DBContext.Product.Where(item => item.ShopId == shopId).ToList();
            var result = products.Take((pageIndex + 1) * pageSize).Skip(pageIndex * pageSize).ToList();
            return (result, products.Count);
        }
        public (List<Product>, int) GetProducts(int pageIndex, int pageSize, double min, double max, string name, string categoryId, CategoryStatus categoryStatus)
        {
            List<Product> products = null;
            if (categoryStatus == CategoryStatus.ACTIVE)
            {
                products = this.DBContext.Product.Where(item => item.RetailPrice >= min && item.RetailPrice <= max && item.Name.Contains(name) && item.CategoryId.Contains(categoryId) && item.Category.Status == CategoryStatus.ACTIVE && item.Status == ProductStatus.ACTIVE).ToList();
            }
            else
            {
                products = this.DBContext.Product.Where(item => item.RetailPrice >= min && item.RetailPrice <= max && item.Name.Contains(name) && item.CategoryId.Contains(categoryId) && item.Status == ProductStatus.ACTIVE).ToList();
            }
            foreach (Product product in products)
            {
                if (product != null)
                {
                    this.DBContext.Entry(product).Reference(item => item.Category).Load();
                }
            }

            var pagelist = (List<Product>)products.Take((pageIndex + 1) * pageSize).Skip(pageIndex * pageSize).ToList();
            return (pagelist, products.Count);
        }

        public (List<Product>, int) GetProductForManage(string shopName, string productName, string categoryId, int pageIndex, int pageSize)
        {
            List<Product> result = new List<Product>();
            List<Product> listProductByName = this.DBContext.Product.Where(item => item.Name.Contains(productName) && item.CategoryId.Contains(categoryId)).ToList();
            foreach (Product product in listProductByName)
            {
                User user = UserRepository.GetUserById(product.ShopId);
                if (user.Name.Contains(shopName))
                {
                    result.Add(product);
                }
            }
            var pagelist = (List<Product>)result.Take((pageIndex + 1) * pageSize).Skip(pageIndex * pageSize).ToList();
            return (pagelist, result.Count);
        }
        public List<Product> GetListProductByCategoryId(string categoryId)
        {
            List<Product> list = this.DBContext.Product.Where(item => item.CategoryId == categoryId).ToList();
            return list;
        }

        public List<Product> GetAllProduct()
        {
            return this.DBContext.Product.ToList<Product>();
        }
    }
}
