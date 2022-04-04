using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalStore.Models
{
    [Table("tblRole")]
    public class Role
    {
        [Key]
        [Required]
        [StringLength(2)]
        public string RoleId { set; get; }

        [Required]
        [StringLength(50)]
        public string RoleName { set; get; }
    }
}
