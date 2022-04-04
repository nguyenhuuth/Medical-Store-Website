
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using System.Collections.Generic;
using MedicalStore.Models;
using MedicalStore.Auth;
using MedicalStore.Controllers.DTO;
using FluentValidation.Results;
using MedicalStore.Utils.Locale;

namespace MedicalStore.Controllers
{
    [Route("/api/cart")]
    [ServiceFilter(typeof(AuthGuard))]
    public class CartApiController : Controller
    {
        private readonly ICartService CartService;
        private readonly IProductService ProductService;
        private const string CartSession = "CartSession";
        public CartApiController(ICartService cartService, IProductService productService)
        {
            this.CartService = cartService;
            this.ProductService = productService;
        }



        [HttpPost("add")]
        public IActionResult HandleAddToCart([FromBody] AddToCartDto body)
        {

            var res = new ServerApiResponse<object>();

            ValidationResult result = new AddToCartDtoValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }


            string cart = this.HttpContext.Session.GetString(CartSession);
            Dictionary<string, CartItem> list = this.CartService.convertStringToCartItem(cart); ;
            if (list == null)
            {
                list = new Dictionary<string, CartItem>();
            }

            Product product = this.ProductService.GetProductById(body.productId);
            if (product.Quantity <= 0)
            {
                Dictionary<string, object> context = new Dictionary<string, object>();
                context.Add("Name", product.Name);
                res.setErrorMessage("Out of stock");
                return new BadRequestObjectResult(res.getResponse());
            }

            foreach (var item in list)
            {
                if (item.Key == body.productId)
                {

                    if (product.Quantity < item.Value.Quantity + body.quantity)
                    {
                        item.Value.Quantity = product.Quantity;
                        this.HttpContext.Session.SetString(CartSession, this.CartService.convertCartItemToString(list));
                        Dictionary<string, object> context = new Dictionary<string, object>();
                        context.Add("Name", product.Name);
                        context.Add("Quantity", product.Quantity);
                        res.setErrorMessage("Out of stock");
                        return new BadRequestObjectResult(res.getResponse());
                    }
                    else
                    {
                        item.Value.Quantity += body.quantity;
                        if (item.Value.Quantity <= 0)
                        {
                            list.Remove(body.productId);
                        }
                    }
                    this.HttpContext.Session.SetString(CartSession, this.CartService.convertCartItemToString(list));
                    res.data = this.CartService.GetCartItems(list);
                    res.setMessage("Add to cart success");
                    return new ObjectResult(res.getResponse());
                }
            }

            var cartItem = new CartItem();
            cartItem.ProductId = product.ProductId;
            cartItem.Quantity = 1;
            list.Add(body.productId, cartItem);
            this.HttpContext.Session.SetString(CartSession, this.CartService.convertCartItemToString(list));
            res.data = this.CartService.GetCartItems(list);
            res.setMessage("Add to cart success");
            return new ObjectResult(res.getResponse());
        }
        [HttpGet("")]
        public IActionResult handleOnGetCart()
        {
            var res = new ServerApiResponse<object>();
            var cart = this.HttpContext.Session.GetString(CartSession) ?? "";

            var list = this.CartService.convertStringToCartItem(cart);

            var getCart = this.CartService.GetCartItems(list);

            res.data = getCart;
            return new ObjectResult(res.getResponse());
        }
    }
}