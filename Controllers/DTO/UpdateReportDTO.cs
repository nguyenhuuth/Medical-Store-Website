using FluentValidation;
using MedicalStore.Utils.Validator;

namespace MedicalStore.Controllers.DTO
{
    public class UpdateReportDTO
    {
        public string ReportId { set; get; }
        public string Description { set; get; }
    }
    public class UpdateReportDTOValidator : AbstractValidator<UpdateReportDTO>
    {
        public UpdateReportDTOValidator()
        {
            RuleFor(x => x.ReportId).NotEmpty().Length(ReportValidator.ID_MIN, ReportValidator.ID_MIN);
            RuleFor(x => x.Description).NotEmpty().Length(ReportValidator.DESCRIPTION_MIN, ReportValidator.DESCRIPTION_MAX);
        }
    }
}
