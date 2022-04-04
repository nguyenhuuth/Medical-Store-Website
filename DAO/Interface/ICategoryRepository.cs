using MedicalStore.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MedicalStore.DAO.Interface
{
    public interface ICategoryRepository
    {
        public Category GetCategoryByID(string categoryId);
        public Category GetCategoryByName(string categoryName);
        public bool CreateCategoryHandler(Category category);
        public bool UpdateCategoryInfoHandler(Category Category);
        public List<SelectListItem> GetListCategoriesByStatus(CategoryStatus categoryStatus);
        public (List<Category>, int) GetAllCategories(int pageIndex, int pageSize);
        public List<Category> GetAllCategories();
    }
}
