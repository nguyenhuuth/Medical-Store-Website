using MedicalStore.Auth;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MedicalStore.Controllers
{
    [Route("report")]
    [ServiceFilter(typeof(AuthGuard))]
    public class ReportController : Controller
    {
        private readonly IReportService ReportService;
        private readonly IUserService UserService;
        private readonly IProductService ProductService;
        public ReportController(IReportService reportService, IUserService userService, IProductService productService)
        {
            this.ReportService = reportService;
            this.UserService = userService;
            this.ProductService = productService;
        }

        [HttpGet("create")]
        public IActionResult CreateReport(string productId)
        {
            var report = ReportService.GetReportByProductID(productId);
            var product = ProductService.GetProductById(productId);
            this.ViewData["product"] = product;
            this.ViewData["report"] = report;
            return View(Routers.CreateReport.Page);
        }

        [HttpGet("detail")]
        public IActionResult ReportDetail(string productId)
        {
            var listReportByProductId = (List<ReportTicket>)ReportService.GetListReportByProductId(productId);
            var product = ProductService.GetProductById(productId);
            this.ViewData["product"] = product;
            this.ViewData["shop"] = UserService.GetUserById(product.ShopId);
            var listCustomer = new List<User>();
            foreach(ReportTicket item in listReportByProductId)
            {
                User user = UserService.GetUserById(item.CustomerId);
                listCustomer.Add(user);
            }
            this.ViewData["listCustomer"] = listCustomer;
            this.ViewData["listReportByProductId"] = listReportByProductId;
            return View(Routers.ReportList.Page);
        }

        [HttpGet("")]
        public IActionResult ReportList(string userId)
        {
            var user = (User)this.ViewData["user"];
            List<Product> listProduct = new List<Product>();
            List<int> reportNums = new List<int>();
            List<string> shopNames = new List<string>();
            if (user == null || user.RoleId != "0")
            {
                return Redirect(Routers.Home.Link);
            }
            var userSearch = UserService.GetUserById(userId);
            if(userSearch.RoleId == "1")
            {
                List<ReportTicket> listReport = this.ReportService.GetListReportByCustomerId(userSearch.UserId);
                foreach (ReportTicket rt in listReport)
                {
                    Product p = this.ProductService.GetProductById(rt.ProductId);
                    if (!(listProduct.Contains(p)))
                    {
                        listProduct.Add(p);
                        shopNames.Add(UserService.GetUserById(p.ShopId).Name);
                    }
                }
                int reportNum = 0;
                foreach (Product p in listProduct)
                {
                    List<ReportTicket> list = this.ReportService.GetListReportByProductId(p.ProductId);
                    foreach (ReportTicket rt in list)
                    {
                        if(rt.ProductId == p.ProductId)
                        {
                            reportNum += 1;
                        }
                    }
                    reportNums.Add(reportNum);
                    reportNum = 0;
                }
            }
            if(userSearch.RoleId == "2")
            {
                var (products, t) = this.ProductService.GetListProductByShopId(userSearch.UserId, 0, 12);
                int reportNum = 0;
                foreach (Product p in products)
                {
                    List<ReportTicket> list = this.ReportService.GetListReportByProductId(p.ProductId);
                    foreach(ReportTicket rt in list)
                    {
                        if(rt.ProductId == p.ProductId)
                        {
                            if (!(listProduct.Contains(p)))
                            {
                                listProduct.Add(p);
                            }
                        }
                    }
                }
                foreach (Product p in listProduct)
                {
                    List<ReportTicket> list = this.ReportService.GetListReportByProductId(p.ProductId);
                    foreach (ReportTicket rt in list)
                    {
                        if (rt.ProductId == p.ProductId)
                        {
                            reportNum += 1;
                        }
                    }
                    reportNums.Add(reportNum);
                    reportNum = 0;
                }
                
            }
            this.ViewData["userSearch"] = userSearch;
            this.ViewData["reportNums"] = reportNums;
            this.ViewData["shopNames"] = shopNames;
            this.ViewData["listProduct"] = listProduct;
            return View(Routers.Report.Page);
        }
    }
}
