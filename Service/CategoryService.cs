using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using MedicalStore.Utils.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MedicalStore.DAO
{
    public class CategoryService : ICategoryService
    {
        private readonly DBContext DBContext;
        private readonly ICategoryRepository CategoryRepository;
        private readonly IProductRepository ProductRepository;
        public CategoryService(DBContext dBContext, ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            this.DBContext = dBContext;
            this.CategoryRepository = categoryRepository;
            this.ProductRepository = productRepository;
        }
        public bool CreateCategoryHandler(Category category)
        {
            return this.CategoryRepository.CreateCategoryHandler(category);
        }

        public bool DeleteCategoryHandler(Category category)
        {
            List<Product> list = this.ProductRepository.GetListProductByCategoryId(category.CategoryId);
            foreach(Product p in list)
            {
                p.Status = ProductStatus.INACTIVE;
                this.ProductRepository.UpdateHandler(p);
            }
            category.Status = CategoryStatus.INACTIVE;
            return this.CategoryRepository.UpdateCategoryInfoHandler(category);
        }

        public (List<Category>, int) GetAllCategories(int pageIndex, int pageSize)
        {
            return this.CategoryRepository.GetAllCategories(pageIndex, pageSize);
        }

        public bool UpdateCategoryInfoHandler(Category category)
        {
            return this.CategoryRepository.UpdateCategoryInfoHandler(category);
        }

        public List<SelectListItem> GetCategoryDropListRender(CategoryStatus categoryStatus)
        {
            return this.CategoryRepository.GetListCategoriesByStatus(categoryStatus);
        }

        public Category GetCategoryByID(string categoryId)
        {
            return this.CategoryRepository.GetCategoryByID(categoryId);
        }

        public List<SelectListItem> GetListCategoriesByStatus(CategoryStatus categoryStatus)
        {
            return this.CategoryRepository.GetListCategoriesByStatus(categoryStatus);
        }

        public List<Category> GetAllCategories()
        {
            return this.CategoryRepository.GetAllCategories();
        }

        public Category GetCategoryByName(string categoryName)
        {
            return this.CategoryRepository.GetCategoryByName(categoryName);
        }
    }
}
