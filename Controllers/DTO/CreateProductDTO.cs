using FluentValidation;
using MedicalStore.Models;
using MedicalStore.Utils.Validator;
using Microsoft.AspNetCore.Http;

namespace MedicalStore.Controllers.DTO
{
    public class CreateProductDTO
    {
        public string ProductId { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public float OriginalPrice { set; get; }
        public float RetailPrice { get; set; }
        public int Quantity { get; set; }
        public IFormFile File { get; set; }
        public string CategoryId { set; get; }
    }

    public class CreateProductDTOValidator : AbstractValidator<CreateProductDTO>
    {
        public CreateProductDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Length(ProductValidator.PRODUCTNAME_MIN, ProductValidator.PRODUCTNAME_MAX);
            RuleFor(x => x.Description).NotEmpty().Length(ProductValidator.DESCRIPTION_MIN, ProductValidator.DESCRIPTION_MAX);
            RuleFor(x => x.OriginalPrice).NotEmpty().InclusiveBetween(ProductValidator.ORIGINALPRICE_MIN, ProductValidator.ORIGINALPRICE_MAX);
            RuleFor(x => x.RetailPrice).NotEmpty().InclusiveBetween(ProductValidator.RETAILPRICE_MIN, ProductValidator.RETAILPRICE_MAX);
            RuleFor(x => x.Quantity).NotEmpty().InclusiveBetween(ProductValidator.QUANTITY_MIN, ProductValidator.QUANTITY_MAX);
            RuleFor(x => x.File).NotNull();
            RuleFor(x => x.CategoryId).NotEmpty();

        }
    }
}
