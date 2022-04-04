using System;
using Microsoft.AspNetCore.Mvc;
using MedicalStore.Utils.Common;
using MedicalStore.Service.Interface;
using Microsoft.AspNetCore.Http;
using MedicalStore.Auth;
using MedicalStore.Models;
using MedicalStore.Utils.Locale;
using MedicalStore.Controllers.DTO;
using FluentValidation.Results;


namespace MedicalStore.Controllers
{

    [Route("/api/order")]
    public class OrderApiController : Controller
    {
        private readonly IOrderService OrderService;
        private const string CartSession = "CartSession";
        private readonly ICartService CartService;
        private readonly IProductService ProductService;
        public OrderApiController(IOrderService orderService, ICartService cartService, IProductService productService)
        {
            this.OrderService = orderService;
            this.CartService = cartService;
            this.ProductService = productService;
        }

        [HttpPost("")]
        [ServiceFilter(typeof(AuthGuard))]
        public IActionResult CreateOrder([FromBody] CreateOrderDTO body)
        {
            var res = new ServerApiResponse<string>();
            string cart = this.HttpContext.Session.GetString(CartSession);
            if (cart == null || cart == "")
            {
                res.setErrorMessage("Cart is empty");
                return new BadRequestObjectResult(res.getResponse());
            }
            ValidationResult result = new CreateOrderDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.setErrorMessage("Order is invalid");
                return new BadRequestObjectResult(res.getResponse());
            }
            float total = 0;
            double profit = 0;
            var list = this.CartService.convertStringToCartItem(cart);
            foreach (var cartItem in list)
            {
                Product product = this.ProductService.GetProductById(cartItem.Key);
                total += product.RetailPrice * cartItem.Value.Quantity;
                if (cartItem.Value.Quantity > product.Quantity)
                {
                    System.Collections.Generic.Dictionary<string, object> context = new System.Collections.Generic.Dictionary<string, object>();
                    context.Add("Name", product.Name);
                    context.Add("Quantity", product.Quantity);
                    res.setErrorMessage("{Name} has {Quantity} left", context);
                    return new BadRequestObjectResult(res.getResponse());
                }
            }
            User customer = (User)ViewData["user"];

            Order order = new Order();
            order.OrderId = Guid.NewGuid().ToString();
            order.Status = OrderStatus.ACTIVE;
            order.Total = total;
            order.CreateDate = DateTime.Now.ToShortDateString();
            order.PaymentMethod = body.PaymentMethod;
            order.CustomerId = customer.UserId;

            this.OrderService.CreateOrderHandler(order);

            foreach (var cartItem in list)
            {
                Product product = this.ProductService.GetProductById(cartItem.Key);
                OrderItem orderItem = new OrderItem();

                orderItem.OrderItemId = Guid.NewGuid().ToString();
                orderItem.Quantity = cartItem.Value.Quantity;
                orderItem.CreateDate = DateTime.Now.ToShortDateString();
                orderItem.SalePrice = product.RetailPrice;
                orderItem.OrderId = order.OrderId;
                orderItem.Profit = (orderItem.SalePrice - product.OriginalPrice) * cartItem.Value.Quantity;
                orderItem.ProductId = product.ProductId;
                product.Quantity -= orderItem.Quantity;
                if(product.Quantity <=0)
                {
                    product.Status = ProductStatus.INACTIVE;
                    ProductService.UpdateProductHandler(product);
                }
                this.OrderService.CreateOrderItemHandler(orderItem);

            }


            this.HttpContext.Session.Remove(CartSession);
            res.setMessage("Order success");
            return new ObjectResult(res.getResponse());
        }
    }
}