using FluentValidation;


namespace MedicalStore.Controllers.DTO
{
    public class AddToCartDto
    {
        public string productId { get; set; }
        public int quantity { get; set; }
    }

    public class AddToCartDtoValidator : AbstractValidator<AddToCartDto>
    {
        public AddToCartDtoValidator()
        {
            RuleFor(x => x.productId).NotNull().NotEmpty();
            RuleFor(x => x.quantity).NotNull().NotEmpty();
        }
    }
}