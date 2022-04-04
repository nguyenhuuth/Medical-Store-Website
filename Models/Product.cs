using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalStore.Models
{
    public enum ProductStatus
    {
        ACTIVE = 1,
        INACTIVE = 0
    }

    [Table("tblProduct")]
    public class Product
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string ProductId { set; get; }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        [Required]
        [StringLength(500)]
        public string Description { set; get; }

        [Required]
        public ProductStatus Status { get; set; }

        [Required]
        public float OriginalPrice { get; set; }

        [Required]
        public float RetailPrice { get; set; }


        [Required]
        [StringLength(50)]
        public string CreateDate { set; get; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageUrl { set; get; }

        [Required]
        [StringLength(50)]
        [ForeignKey("tblCategory")]
        public string CategoryId { set; get; }

        public virtual Category Category { set; get; }

        [Required]
        [StringLength(50)]
        [ForeignKey("tblUser")]
        public string ShopId { set; get; }
        
        public virtual User Shop { set; get; }
    }
}
