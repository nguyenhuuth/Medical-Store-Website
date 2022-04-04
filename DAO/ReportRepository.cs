using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using System.Collections.Generic;
using System.Linq;

namespace MedicalStore.DAO
{
    public class ReportRepository : IReportRepository
    {
        private readonly DBContext DBContext;

        public ReportRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }
        public bool DeleteReportHandler(ReportTicket report)
        {
            this.DBContext.ReportTicket.Update(report);
            return this.DBContext.SaveChanges() > 0;
        }

        public List<ReportTicket> GetAllReprot()
        {
            List<ReportTicket> listReport = this.DBContext.Set<ReportTicket>().ToList<ReportTicket>();
            return listReport;
        }

        public ReportTicket GetReportById(string id)
        {
            ReportTicket report = this.DBContext.ReportTicket.FirstOrDefault(item => item.ReportId == id);
            return report;
        }

        public ReportTicket GetReportByProductID(string productId)
        {
            ReportTicket report = this.DBContext.ReportTicket.FirstOrDefault(item => item.ProductId == productId);
            return report;
        }

        public bool CreateReportHandler(ReportTicket report)
        {
            this.DBContext.ReportTicket.Add(report);
            return this.DBContext.SaveChanges() > 0;
        }

        public bool UpdateReportInfoHandler(ReportTicket report)
        {
            this.DBContext.ReportTicket.Update(report);
            this.DBContext.SaveChanges();
            return true;
        }

        public List<ReportTicket> GetListReportByProductId(string productId)
        {
            List<ReportTicket> list = this.DBContext.ReportTicket.Where(item => item.ProductId == productId).ToList();
            return list;
        }

        public List<ReportTicket> GetListReportByCustomerId(string customerId)
        {
            List<ReportTicket> list = this.DBContext.ReportTicket.Where(item => item.CustomerId == customerId).ToList();
            return list;
        }
    }
}
