using FluentValidation;
using MedicalStore.Utils.Validator;

namespace MedicalStore.Controllers.DTO
{
    public class CreateCategoryDTO
    {
        public string Name { set; get; }
        public string Description { set; get; }
    }
    public class CreateCategoryDTOValidator : AbstractValidator<CreateCategoryDTO>
    {
        public CreateCategoryDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Length(CategoryValidator.NAME_MIN, CategoryValidator.NAME_MAX);
            RuleFor(x => x.Description).Length(CategoryValidator.DESCRIPTION_MIN, CategoryValidator.DESCRIPTION_MAX);
        }
    }
}
