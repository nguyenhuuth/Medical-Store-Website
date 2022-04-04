using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalStore.Models
{
    public enum ReportStatus
    {
        ACTIVE = 1,
        INACTIVE = 0
    }

    [Table("tblReportTicket")]
    public class ReportTicket
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string ReportId { set; get; }

        [Required]
        [StringLength(500)]
        public string Description { set; get; }

        [Required]
        public ReportStatus Status { set; get; }


        [StringLength(50)]
        [ForeignKey("tblUser")]
        public string CustomerId { set; get; }
        public virtual User Customer { set; get; }

  
        [StringLength(50)]
        [ForeignKey("tblProduct")]
        public string ProductId { set; get; }
        public virtual Product Product { set; get; }
    }
}
