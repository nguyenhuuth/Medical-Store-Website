using MedicalStore.Models;
using Microsoft.AspNetCore.Mvc;
using MedicalStore.Auth;
using System;
using MedicalStore.Service.Interface;
using MedicalStore.DAO.Interface;
using MedicalStore.Utils.Common;
using Microsoft.AspNetCore.Http;
using MedicalStore.Utils.Locale;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MedicalStore.Controllers
{
    [Route("")]
    [ServiceFilter(typeof(AuthGuardGuest))]

    public class HomeController : Controller
    {
        private const string CartSession = "CartSession";
        private readonly ICartService CartService;
        private readonly IProductService ProductService;
        private readonly ICategoryService CategoryService;


        public HomeController(IProductService productService, ICategoryService categoryService, ICartService cartService)
        {
            this.ProductService = productService;
            this.CategoryService = categoryService;
            this.CartService = cartService;
        }

        [HttpGet("")]
        public IActionResult Index(double min, double max, string name, string categoryId, string message, string errorMessage, int pageIndex = 0, int pageSize = 12)
        {
            var user = (User)this.ViewData["user"];
            if (user != null)
            {
                if (user.RoleId == "0")
                {
                    return Redirect(Routers.Product.Link);
                }
                if (user.RoleId == "2")
                {
                    return Redirect(Routers.Product.Link);
                }
            }
            var cart = this.HttpContext.Session.GetString(CartSession) ?? "";

            var list = this.CartService.convertStringToCartItem(cart);

            var getCart = this.CartService.GetCartItems(list);
            this.ViewData["cartItems"] = getCart;

            var categories = this.CategoryService.GetCategoryDropListRender(CategoryStatus.ACTIVE);
            var allCategory = new SelectListItem()
            {
                Value = "",
                Text = "All"
            };

            categories.Add(allCategory);

            if (name == null) name = "";
            if (categoryId == null) categoryId = "";
            if (max < 0)
            {
                ServerResponse.SetFieldErrorMessage("max", "Min must be greater than zero", this.ViewData);
                max = 9999999;
            }
            if (max == 0)
            {
                max = 9999999;
                var query = $"?min={min}&max={max}&name={name}&CategoryId={categoryId}&message={message}&errorMessage={errorMessage}";
                return Redirect(Routers.Home.Link + query);
            }
            this.ViewData["categories"] = new SelectList(categories);
            var (products, count) = this.ProductService.GetProducts(pageIndex, pageSize, min, max, name, categoryId, CategoryStatus.ACTIVE);
            if (min < 0)
            {
                ServerResponse.SetFieldErrorMessage("min", "Min must be greater than zero", this.ViewData);
                min = 0;
            }

            if (min > max)
            {
                ServerResponse.SetErrorMessage("Max must be greater than min", this.ViewData);
            }
            this.ViewData["products"] = products;
            this.ViewData["total"] = count;
            return View(Routers.Home.Page);
        }

    }
}
