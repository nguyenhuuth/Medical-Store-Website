using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.Service.Interface
{
    public interface IReportService
    {
        public bool CreateReportHandler(ReportTicket report);
        public bool UpdateReportInfoHandler(ReportTicket report);
        public bool DeleteReportHandler(ReportTicket report);
        public ReportTicket GetReportById(string id);
        List<ReportTicket> GetAllReprot();
        public ReportTicket GetReportByProductID(string productId);
        public List<ReportTicket> GetListReportByProductId(string productId);
        public List<ReportTicket> GetListReportByShopId(string shopId);
        public List<ReportTicket> GetListReportByCustomerId(string customerId);
    }
}
