using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Data.Entities
{
    public class User : BaseEntity
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo nome é obrigatório!")]
        [StringLength(50, ErrorMessage = "O nome deve conter no máximo 50 caracteres!")]
        [Column("name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A senha é obrigatoria!")]
        [StringLength(8, ErrorMessage = " A senha deve conter no máximo 8 caracteres!")]
        [Column("password")]
        public string Password { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "A Login é obrigatorio!")]
        [StringLength(11, MinimumLength =11, ErrorMessage = "O login deve conter 11 caracteres!")]
        [Column("login")]
        public string Login { get; set; }

    }
}
