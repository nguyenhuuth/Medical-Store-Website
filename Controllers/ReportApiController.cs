using FluentValidation.Results;
using MedicalStore.Auth;
using MedicalStore.Controllers.DTO;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using MedicalStore.Utils.Locale;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicalStore.Controllers
{
    [Route("/api/report")]
    [ServiceFilter(typeof(AuthGuard))]
    public class ReportApiController : Controller
    {
        private readonly IReportService ReportService;
        public ReportApiController(IReportService reportService, IReportRepository reportRespository)
        {
            this.ReportService = reportService;
        }

        [HttpPost("create")]
        public IActionResult HandleCreate([FromBody] CreateReportDTO body)
        {
            var res = new ServerApiResponse<string>();
            ValidationResult result = new CreateReportDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }
            User user = (User)this.ViewData["user"];

            var report = new ReportTicket();
            report.ReportId = Guid.NewGuid().ToString();
            report.Description = body.Description.Trim();
            report.Status = ReportStatus.ACTIVE;
            report.ProductId = body.ProductId.Trim();
            report.CustomerId = user.UserId;

            this.ReportService.CreateReportHandler(report);
            res.setMessage("Report success!");
            return new ObjectResult(res.getResponse());
        }

        [HttpPost("update")]
        public IActionResult HandlerUpdate([FromBody] UpdateReportDTO body)
        {
            var res = new ServerApiResponse<string>();

            ValidationResult result = new UpdateReportDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }
            var report = ReportService.GetReportById(body.ReportId);
            report.Description = body.Description.Trim();

            this.ReportService.UpdateReportInfoHandler(report);

            res.setMessage("Update report success!");
            return new ObjectResult(res.getResponse());
        }

        [HttpPost("delete")]
        public IActionResult HandleDelete([FromBody] UpdateReportDTO body)
        {
            var res = new ServerApiResponse<string>();

            var report = ReportService.GetReportById(body.ReportId);
            report.Status = ReportStatus.INACTIVE;

            this.ReportService.DeleteReportHandler(report);

            res.setMessage("Update report success!");
            return new ObjectResult(res.getResponse());
        }
    }

}
