using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicalStore.Models
{
    public enum PaymentStatus
    {
        PAID = 1,
        PENDING = 0
    }

    [Table("tblPayment")]
    public class Payment
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string PaymentId { set; get; }

        [Required]
        [StringLength(50)]
        public string PaymentProvider { set; get; }

        [Required]
        [StringLength(50)]
        public string PaymentTime { set; get; }

        [Required]
        public PaymentStatus Status { set; get; }

        [Required]
        [StringLength(50)]
        [ForeignKey("tblOrder")]
        public string OrderId { set; get; }
        public virtual Order Order { set; get; }
    }
}
