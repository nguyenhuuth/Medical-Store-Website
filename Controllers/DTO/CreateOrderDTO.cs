using FluentValidation;
using MedicalStore.Models;

namespace MedicalStore.Controllers.DTO
{
    public class CreateOrderDTO
    {
        public PaymentMethod PaymentMethod { get; set; }
    }
    public class CreateOrderDTOValidator : AbstractValidator<CreateOrderDTO>
    {
        public CreateOrderDTOValidator()
        {
            RuleFor(x => x.PaymentMethod).NotNull().IsInEnum();
        }
    }
}