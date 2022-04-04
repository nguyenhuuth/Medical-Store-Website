using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalStore.Models
{
    public enum UserRole
    {
        MANAGER = 0,
        CUSTOMER = 1,
        SELLER = 2,
    }

    public enum UserStatus
    {
        ACTIVE = 1,
        INACTIVE = 0
    }

    [Table("tblUser")]
    public class User
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string UserId { set; get; }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        [Required]
        [StringLength(50)]
        public string Username { set; get; }

        [StringLength(50)]
        public string Password { set; get; }

        [Required]
        [StringLength(250)]
        public string Email { set; get; }

        [Required]
        [StringLength(10)]
        public string Phone { set; get; }

        [StringLength(250)]
        public string Address { set; get; }

        [Required]
        [StringLength(50)]
        public string CreateDate { set; get; }

        [Required]
        public UserStatus Status { set; get; }

        [Required]
        [StringLength(2)]
        [ForeignKey("tblRole")]
        public string RoleId { get; set; }

        public virtual Role Role { set; get; }
    }
}
