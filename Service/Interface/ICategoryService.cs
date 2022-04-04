using MedicalStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface ICategoryService
    {
        public bool CreateCategoryHandler(Category category);
        public bool UpdateCategoryInfoHandler(Category category);
        public bool DeleteCategoryHandler(Category category);
        public (List<Category>, int) GetAllCategories(int pageIndex, int pageSize);
        public List<SelectListItem> GetCategoryDropListRender(CategoryStatus categoryStatus);
        public Category GetCategoryByID(string categoryId);
        public List<SelectListItem> GetListCategoriesByStatus(CategoryStatus categoryStatus);
        public List<Category> GetAllCategories();
        public Category GetCategoryByName(string categoryName);
    }
}
