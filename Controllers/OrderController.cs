using Microsoft.AspNetCore.Mvc;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils.Common;
using MedicalStore.Service.Interface;
using MedicalStore.Auth;
using System;
using System.Collections.Generic;

namespace MedicalStore.Controllers
{
    [Route("order")]
    [ServiceFilter(typeof(AuthGuard))]
    public class OrderController : Controller
    {
        private readonly IOrderService OrderService;
        private const string CartSession = "CartSession";
        private readonly ICartService CartService;
        private readonly IProductService ProductService;
        private readonly IUserService UserService;
        private readonly IOrderItemService OrderItemService;
        public OrderController(IOrderService orderService, ICartService cartService, IProductService productService, IUserService userService, IOrderItemService orderItemService)
        {
            this.OrderService = orderService;
            this.CartService = cartService;
            this.ProductService = productService;
            this.UserService = userService;
            this.OrderItemService = orderItemService;
        }

        [HttpGet("")]
        [RoleGuardAttribute("1")]
        [ServiceFilter(typeof(AuthGuard))]
        public IActionResult Order(string startDate, string endDate, int pageIndex = 0, int pageSize = 12)
        {
            var user = (User)this.ViewData["user"];
            var now = DateTime.Now;
            string lastDate = now.AddDays(1).ToString("yyyy-MM-dd");
            string firstDate = now.AddYears(-1).ToString("yyyy-MM-dd");
            var res = new ServerApiResponse<string>();
            DateTime lDate = Convert.ToDateTime(lastDate);
            DateTime fDate = Convert.ToDateTime(firstDate);

            if (startDate == null || endDate == null)
            {
                var query = $"?startDate={firstDate}&endDate={lastDate}&search=";
                return Redirect(Routers.Order.Link + query);
            }

            try
            {
                var (orders, total) = this.OrderService.GetOrders(startDate, endDate, user.UserId, pageIndex, pageSize);
                orders.Sort((x, y) => y.CreateDate.CompareTo(x.CreateDate));
                this.ViewData["orders"] = orders;
                this.ViewData["total"] = total;
                return View(Routers.Order.Page);
            }
            catch (System.Exception)
            {
                var query = $"?startDate={firstDate}&endDate={lastDate}&search=";
                return Redirect(Routers.Order.Link + query);
            }
        }

        [HttpGet("detail")]
        [ServiceFilter(typeof(AuthGuard))]
        public IActionResult OrderDetail(string orderId, int pageIndex = 0, int pageSize = 1000)
        {
            User user = (User)this.ViewData["user"];
            var (items, count) = this.OrderService.GetOrderDetail(orderId, pageIndex, pageSize);
            Order order = this.OrderService.GetOrderByOrderId(orderId);
            List<Product> listProduct = new List<Product>();
            List<string> listShopName = new List<string>();
            float total = 0;
            if(user.RoleId == "1") 
            {
                foreach(OrderItem oi in items)
                {
                    Product p = ProductService.GetProductById(oi.ProductId);
                    listProduct.Add(p);
                    listShopName.Add(UserService.GetUserById(p.ShopId).Name);
                }
                total = order.Total;
            }if(user.RoleId == "2") 
            {
                foreach (OrderItem oi in items)
                {
                    Product p = ProductService.GetProductById(oi.ProductId);
                    if(p.ShopId == user.UserId) { 
                        listProduct.Add(p);
                        listShopName.Add(user.Name);
                        total += oi.SalePrice * oi.Quantity;
                    }                    
                }
            }
            this.ViewData["listProduct"] = listProduct;
            this.ViewData["listShopName"] = listShopName;
            this.ViewData["listOrderItem"] = items;
            this.ViewData["total"] = total;
            this.ViewData["order"] = order;
            this.ViewData["customerName"] = this.UserService.GetUserById(order.CustomerId).Name;
            return View(Routers.OrderDetail.Page);
        }


        [HttpGet("manager")]
        [RoleGuardAttribute("2")]
        [ServiceFilter(typeof(AuthGuard))]
        public IActionResult GetSoldOrders(string startDate, string endDate, string search, int pageIndex = 0, int pageSize = 12)
        {
            var now = DateTime.Now;
            var user = (User)this.ViewData["user"];
            string lastDate = now.AddDays(1).ToString("yyyy-MM-dd");
            string firstDate = now.AddYears(-1).ToString("yyyy-MM-dd");

            if (startDate == null || endDate == null)
            {
                var query = $"?startDate={firstDate}&endDate={lastDate}&search=";
                return Redirect(Routers.OrderManager.Link + query);
            }

            try
            {
                var (orders, total) = this.OrderService.SearchOrders(startDate, endDate, search, pageIndex, pageSize, user.UserId);
                List<OrderItem> items = new List<OrderItem>();
                float profit = 0;
                foreach (Order o in orders)
                {
                    List<OrderItem> list = OrderItemService.GetAllOrderItemByOrderId(o.OrderId);
                    items.AddRange(list);
                }
                foreach (OrderItem item in items)
                {
                    Product p = ProductService.GetProductById(item.ProductId);
                    if(p.ShopId == user.UserId)
                    {
                        profit += (float)item.Profit;
                    }
                }
                this.ViewData["profit"] = profit;
                this.ViewData["orders"] = orders;
                this.ViewData["total"] = total;
                return View(Routers.OrderManager.Page);
            }
            catch (System.Exception)
            {

                var query = $"?startDate={firstDate}&endDate={lastDate}&search=";
                return Redirect(Routers.OrderManager.Link + query);
            }
        }
    }
}
