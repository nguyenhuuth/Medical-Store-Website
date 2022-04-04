using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalStore.Models
{
    [Table("tblOrderItem")]
    public class OrderItem
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string OrderItemId { set; get; }

        [Required]
        public int Quantity { set; get; }

        [Required]
        public float SalePrice { set; get; }

        [Required]
        public double Profit { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateDate { set; get; }

        [StringLength(50)]
        [ForeignKey("tblOrder")]
        public string OrderId { set; get; }
        public virtual Order Order { set; get; }


        
        [StringLength(50)]
        [ForeignKey("tblProduct")]
        public string ProductId { set; get; }

        public virtual Product Product { set; get; }
    }
    
}
