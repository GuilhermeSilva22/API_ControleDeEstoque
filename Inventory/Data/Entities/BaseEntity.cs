using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Data.Entities
{
    public class BaseEntity
    {
        [Required(ErrorMessage = "O id é obrigatorio!")]
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Required]
        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}
