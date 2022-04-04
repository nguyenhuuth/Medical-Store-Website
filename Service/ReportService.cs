using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils;
using System.Collections.Generic;

namespace MedicalStore.Service
{
    public class ReportService : IReportService
    {
        private readonly DBContext DBContext;
        private readonly IReportRepository ReportRepository;
        private readonly IProductRepository ProductRepository;

        public ReportService(DBContext dBContext, IReportRepository reportRepository, IProductRepository productRepository)
        {
            this.DBContext = dBContext;
            ReportRepository = reportRepository;
            ProductRepository = productRepository;
        }

        public bool CreateReportHandler(ReportTicket report)
        {
            return this.ReportRepository.CreateReportHandler(report);
        }

        public bool DeleteReportHandler(ReportTicket report)
        {
            return this.ReportRepository.DeleteReportHandler(report);
        }

        public List<ReportTicket> GetAllReprot()
        {
            return this.ReportRepository.GetAllReprot();
        }

        public List<ReportTicket> GetListReportByProductId(string productId)
        {
            return this.ReportRepository.GetListReportByProductId(productId);
        }

        public List<ReportTicket> GetListReportByShopId(string shopId)
        {
            var (listProduct, t) = this.ProductRepository.GetListProductByShopId(shopId, 0, 12);
            List<ReportTicket> result = new List<ReportTicket>();
            foreach (Product p in listProduct)
            {
                result.AddRange(this.ReportRepository.GetListReportByProductId(p.ProductId));
            }
            return result;
        }

        public ReportTicket GetReportById(string id)
        {
            return this.ReportRepository.GetReportById(id);
        }

        public ReportTicket GetReportByProductID(string product)
        {
            return this.ReportRepository.GetReportByProductID(product);
        }

        public bool UpdateReportInfoHandler(ReportTicket report)
        {
            return this.ReportRepository.UpdateReportInfoHandler(report);
        }

        public List<ReportTicket> GetListReportByCustomerId(string customerId)
        {
            return this.ReportRepository.GetListReportByCustomerId(customerId);
        }
    }
}
