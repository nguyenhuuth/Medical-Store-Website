using FluentValidation;
using MedicalStore.Utils.Validator;

namespace MedicalStore.Controllers.DTO
{
    public class CreateReportDTO
    {
        public string Description { get; set; }
        public string ProductId { get; set; }

    }
    public class CreateReportDTOValidator : AbstractValidator<CreateReportDTO>
    {
        public CreateReportDTOValidator()
        {
            RuleFor(x => x.Description).NotEmpty().Length(ReportValidator.DESCRIPTION_MIN, ReportValidator.DESCRIPTION_MAX);
            RuleFor(x => x.ProductId).NotEmpty().Length(ReportValidator.ID_MIN, ReportValidator.ID_MAX);
        }
    }
}
