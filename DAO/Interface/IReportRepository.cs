using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface IReportRepository
    {
        public ReportTicket GetReportById(string id);
        public bool CreateReportHandler(ReportTicket report);
        public bool UpdateReportInfoHandler(ReportTicket report);
        public bool DeleteReportHandler(ReportTicket report);
        List<ReportTicket> GetAllReprot();
        public ReportTicket GetReportByProductID(string categoryID);
        public List<ReportTicket> GetListReportByProductId(string productId);
        public List<ReportTicket> GetListReportByCustomerId(string customerId);
    }
}
