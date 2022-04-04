using Microsoft.AspNetCore.Mvc;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils.Common;
using System.Collections.Generic;
using MedicalStore.Controllers.DTO;
using System.Linq;
using MedicalStore.Service.Interface;
using MedicalStore.Auth;

namespace MedicalStore.Controllers
{
    [Route("admin")]
    [ServiceFilter(typeof(AuthGuard))]
    public class AdminController : Controller
    {
        private readonly IUserService UserService;
        private readonly IOrderService OrderService;
        private readonly IProductService ProductService;
        private readonly IReportService ReportService;
        private readonly IOrderItemService OrderItemService;

        public AdminController(IUserService userService, IProductService productService, IOrderService orderService, IReportService reportService, IOrderItemService orderItemService)
        {
            this.UserService = userService;
            this.OrderService = orderService;
            this.ProductService = productService;
            this.ReportService = reportService;
            this.OrderItemService = orderItemService;
        }

        [HttpGet("")]
        public IActionResult GetAllProduct(int pageIndex = 0, int pageSize = 12)
        {
            return Redirect(Routers.Product.Link);
        }
         
        public class UserList
        {
            public User user { get; set; }
            public int orderNums { get; set; }
            public int productNums { get; set; }
            public int reportNums { get; set; }
            public float money { get; set; }
        }

        [HttpGet("seller")]
        public IActionResult GetAllSeller(string sortBy)
        {
            var user = (User)this.ViewData["user"];
            if (user == null || user.RoleId != "0")
            {
                return Redirect(Routers.Home.Link);
            }
            var listSeller = (List<User>)UserService.GetAllUserByRoleId("2");
            List<int> orderNums = new List<int>();
            List<int> productNums = new List<int>();
            List<int> reportNums = new List<int>();
            List<float> profits = new List<float>();
            foreach(User u in listSeller)
            {
                List<Order> listSoldOrder = OrderService.GetlistSoldOrder(u.UserId);
                orderNums.Add(listSoldOrder.Count);
                var (products, t) = this.ProductService.GetListProductByShopId(u.UserId, 0, 12);
                productNums.Add(products.Count);
                float profit = 0;
                foreach(Product p in products)
                {
                    List<OrderItem> orderItems = this.OrderItemService.GetAllOrderItemByProductId(p.ProductId);
                    foreach(OrderItem oi in orderItems)
                    {
                        profit = profit + (float)oi.Profit;
                    }
                }
                profits.Add(profit);
                int reportNum = ReportService.GetListReportByShopId(u.UserId).Count;                
                reportNums.Add(reportNum);
            }
            List<UserList> list = new List<UserList>();
            for(int i = 0; i < listSeller.Count; i++)
            {
                UserList sellerList = new UserList();
                sellerList.user = listSeller[i];
                sellerList.money  = profits[i];  
                sellerList.productNums = productNums[i];
                sellerList.reportNums = reportNums[i];
                sellerList.orderNums = orderNums[i];   
                list.Add(sellerList);
                list.Sort((x, y) => y.money.CompareTo(x.money));
            }

            if(sortBy == "orderIncreasing")
            {
                list.Sort((x, y) => x.orderNums.CompareTo(y.orderNums));
            }
            if (sortBy == "orderDecreasing")
            {
                list.Sort((x, y) => y.orderNums.CompareTo(x.orderNums));
            }
            if (sortBy == "reportIncreasing")
            {
                list.Sort((x, y) => x.reportNums.CompareTo(y.reportNums));
            }
            if (sortBy == "reportDecreasing")
            {
                list.Sort((x, y) => y.reportNums.CompareTo(x.reportNums));
            }
            if (sortBy == "profitIncreasing")
            {
                list.Sort((x, y) => x.money.CompareTo(y.money));
            }
            if (sortBy == "profitDecreasing")
            {
                list.Sort((x, y) => y.money.CompareTo(x.money));
            }

            for (int i = 0; i < list.Count; i++)
            {
                orderNums[i] = list[i].orderNums;
                productNums[i] = list[i].productNums;
                reportNums[i] = list[i].reportNums;
                profits[i] = list[i].money;
                listSeller[i] = list[i].user;
            }
            
            this.ViewData["orderNums"] = orderNums;
            this.ViewData["productNums"] = productNums;
            this.ViewData["reportNums"] = reportNums;
            this.ViewData["profits"] = profits;
            this.ViewData["listSeller"] = listSeller;
            return View(Routers.SellerManage.Page);
        }
        [HttpGet("customer")]
        public IActionResult GetAllCustomer(string sortBy)
        {
            var user = (User)this.ViewData["user"];
            if (user == null || user.RoleId != "0")
            {
                return Redirect(Routers.Home.Link);
            }
            var listCustomer = (List<User>)UserService.GetAllUserByRoleId("1");
            List<int> reportNums = new List<int>();
            List<int> orderNums = new List<int>();
            List<float> totals = new List<float>();
            foreach(User u in listCustomer)
            {
                float t = 0;
                List<Order> orders = this.OrderService.GetOrdersHistory(u.UserId);
                orderNums.Add(orders.Count);
                foreach(Order order in orders)
                {
                    if(order.Status != OrderStatus.INACTIVE)
                    t += order.Total;
                }
                totals.Add(t);
                List<ReportTicket> reportTickets = this.ReportService.GetListReportByCustomerId(u.UserId);
                reportNums.Add(reportTickets.Count);
            }
            List<UserList> list = new List<UserList>();
            for (int i = 0; i < listCustomer.Count; i++)
            {
                UserList sellerList = new UserList();
                sellerList.user = listCustomer[i];
                sellerList.money = totals[i];
                sellerList.productNums = 0;
                sellerList.reportNums = reportNums[i];
                sellerList.orderNums = orderNums[i];
                list.Add(sellerList);
                list.Sort((x, y) => y.money.CompareTo(x.money));
            }

            if (sortBy == "buyIncreasing")
            {
                list.Sort((x, y) => x.money.CompareTo(y.money));
            }
            if (sortBy == "buyDecreasing")
            {
                list.Sort((x, y) => y.money.CompareTo(x.money));
            }
            if (sortBy == "reportIncreasing")
            {
                list.Sort((x, y) => x.reportNums.CompareTo(y.reportNums));
            }
            if (sortBy == "reportDecreasing")
            {
                list.Sort((x, y) => y.reportNums.CompareTo(x.reportNums));
            }

            for (int i = 0; i < list.Count; i++)
            {
                orderNums[i] = list[i].orderNums;
                reportNums[i] = list[i].reportNums;
                totals[i] = list[i].money;
                listCustomer[i] = list[i].user;
            }

            this.ViewData["reportNums"] = reportNums;
            this.ViewData["orderNums"] = orderNums;
            this.ViewData["totals"] = totals;
            this.ViewData["listCustomer"] = listCustomer;
            return View(Routers.CustomerManage.Page);
        }

    }
}
