using FluentValidation.Results;
using MedicalStore.Auth;
using MedicalStore.Controllers.DTO;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using MedicalStore.Utils.Interface;
using MedicalStore.Utils.Locale;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicalStore.Controllers
{
    [Route("/api/product")]
    [ServiceFilter(typeof(AuthGuard))]
    public class ProductApiController : Controller
    {
        private readonly IProductService ProductService;
        private readonly ICategoryService CategoryService;

        private readonly IUploadFileService UploadFileService;
        public ProductApiController(IProductRepository productRepository, IProductService productService, ICategoryService categoryService, IUploadFileService uploadFileService)
        {
            this.ProductService = productService;
            this.CategoryService = categoryService;
            this.UploadFileService = uploadFileService;
        }

        [HttpPost("create")]
        public IActionResult HandleCreateProduct([FromForm] CreateProductDTO body)

        {
            if (body == null)
            {
                body = new CreateProductDTO();
            }
            var res = new ServerApiResponse<string>();
            ValidationResult result = new CreateProductDTOValidator().Validate(body);

            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }
            var isExistProduct = this.ProductService.GetProductByName(body.Name.Trim());
            User user = (User)this.ViewData["user"];
            if (isExistProduct != null && isExistProduct.ShopId == user.UserId)
            {
                res.setErrorMessage("Product " + body.Name + " is already exist in your shop!!");
                return new BadRequestObjectResult(res.getResponse());
            }
            if(body.OriginalPrice > body.RetailPrice) 
            {
                res.setErrorMessage("Product's Retail Price must be greater than Origina lPrice!!");
                return new BadRequestObjectResult(res.getResponse());
            }
            Console.WriteLine(body.File);
            var imageUrl = this.UploadFileService.Upload(body.File);
            Console.WriteLine(imageUrl);
            if (imageUrl == null)
            {
                res.setErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_UPLOAD_FILE_FAILED, "File");
                return new BadRequestObjectResult(res.getResponse());
            }

            var product = new Product();
            product.ProductId = Guid.NewGuid().ToString();
            product.Name = body.Name.Trim();
            product.Description = body.Description.Trim();
            product.OriginalPrice = body.OriginalPrice;
            product.RetailPrice = body.RetailPrice;
            product.Quantity = body.Quantity;
            product.ImageUrl = imageUrl;
            product.CategoryId = body.CategoryId;
            product.ShopId = user.UserId;
            product.CreateDate = DateTime.Now.ToShortDateString();
            if(product.Quantity <= 0)
            {
                product.Status = ProductStatus.INACTIVE;
            }
            else 
            { 
            product.Status = ProductStatus.ACTIVE;
            }
            this.ProductService.CreateProductHandler(product);
            res.setMessage("Create Product Success!");
            return new ObjectResult(res.getResponse());
        }

        [HttpPost("update")]
        public IActionResult HandleUpdateProduct([FromForm] UpdateProductDTO body)
        {
            if (body == null)
            {
                body = new UpdateProductDTO();
            }
            var res = new ServerApiResponse<string>();
            ValidationResult result = new UpdateProductDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }
            var product = this.ProductService.GetProductById(body.ProductId);
            if (product == null)
            {
                res.setErrorMessage("Cannot find product with Id" + body.ProductId);
                return new NotFoundObjectResult(res.getResponse());
            }

            if (product.Name != body.ProductName)
            {
                var isExistProduct = this.ProductService.GetProductByName(body.ProductName);
                if (isExistProduct != null)
                {
                    res.setErrorMessage("Product " + body.ProductName + " already exist in your shop!!");
                    return new BadRequestObjectResult(res.getResponse());
                }
            }
            if (body.OriginalPrice > body.RetailPrice)
            {
                res.setErrorMessage("Product's Retail Price must be greater than Origina lPrice!!");
                return new BadRequestObjectResult(res.getResponse());
            }
            if (body.File != null)
            {
                var imageUrl = this.UploadFileService.Upload(body.File);
                product.ImageUrl = imageUrl;
            }

            product.Name = body.ProductName.Trim();
            product.Description = body.ProductDescription.Trim();
            product.OriginalPrice = body.OriginalPrice;
            product.RetailPrice = body.RetailPrice;
            if(product.Quantity != 0 && product.Status == ProductStatus.INACTIVE)
            {
                product.Quantity = body.Quantity;
                product.Status = ProductStatus.INACTIVE;
            }
            else
            {
                product.Quantity = body.Quantity;
                product.Status = ProductStatus.ACTIVE;
            }
            
            

            this.ProductService.UpdateProductHandler(product);
            res.setMessage("Update Product Success!!");
            return new ObjectResult(res.getResponse());

        }

        [HttpPost("delete")]
        public IActionResult HandleDeleteProduct([FromForm] UpdateProductDTO body)
        {
            var res = new ServerApiResponse<string>();
            var product = ProductService.GetProductById(body.ProductId);
            if (product != null)
            {
                if(product.Status == ProductStatus.ACTIVE)
                {
                    product.Status = ProductStatus.INACTIVE;
                }
                else
                {
                    product.Status = ProductStatus.ACTIVE;                   
                }
                ProductService.UpdateProductHandler(product);
            }            
            res.setMessage("Update Product Success!");
            return new ObjectResult(res.getResponse());
        }
    }


}
