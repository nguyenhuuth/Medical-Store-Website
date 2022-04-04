using FluentValidation;
using MedicalStore.Utils.Validator;

namespace MedicalStore.Controllers.DTO
{
    public class UpdateCategoryDTO
    {
        public string CategoryId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }   
    }
    public class UpdateCategoryDTOValidator : AbstractValidator<UpdateCategoryDTO>
    {
        public UpdateCategoryDTOValidator()
        {

            RuleFor(x => x.CategoryId).NotEmpty().Length(CategoryValidator.ID_MIN, CategoryValidator.ID_MAX);
            RuleFor(x => x.Name).NotEmpty().Length(CategoryValidator.NAME_MIN, CategoryValidator.NAME_MAX);
            RuleFor(x => x.Description).Length(CategoryValidator.DESCRIPTION_MIN, CategoryValidator.DESCRIPTION_MAX);
        }
    }
}
