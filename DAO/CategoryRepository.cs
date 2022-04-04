using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace MedicalStore.DAO
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DBContext DBContext;
        public CategoryRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }
        public bool CreateCategoryHandler(Category category)
        {
            this.DBContext.Category.Add(category);
            return this.DBContext.SaveChanges() > 0;
        }

        public Category GetCategoryByID(string categoryId)
        {
            Category category = this.DBContext.Category.FirstOrDefault(item => item.CategoryId == categoryId);
            return category;
        }

        public bool UpdateCategoryInfoHandler(Category category)
        {
            this.DBContext.Category.Update(category);
            return this.DBContext.SaveChanges() > 0;
        }

        public List<Category> GetAllCategories()
        {
            List<Category> listCategory = this.DBContext.Category.ToList();
            return listCategory;
        }

        public List<SelectListItem> GetListCategoriesByStatus(CategoryStatus categoryStatus)
        {
            var categories = new List<SelectListItem>();
            IEnumerable<Category> listCategories;
            if (categoryStatus == CategoryStatus.ACTIVE)
            {
                listCategories = this.GetAllCategories().Where(item => item.Status == CategoryStatus.ACTIVE);
            }
            else
            {
                listCategories = this.GetAllCategories();
            }
            foreach (var item in listCategories)
            {
                categories.Add(new SelectListItem()
                {
                    Value = item.CategoryId,
                    Text = item.Name,
                });
            }
            return categories;
        }

        public (List<Category>, int) GetAllCategories(int pageIndex, int pageSize)
        {
            List<Category> categories = this.DBContext.Category.ToList();
            var result = categories.Take((pageIndex + 1) * pageSize).Skip(pageIndex * pageSize).ToList();
            return (result, categories.Count);
        }

        public Category GetCategoryByName(string categoryName)
        {
            return this.DBContext.Category.FirstOrDefault<Category>(item => item.Name == categoryName);
        }
    }
}
