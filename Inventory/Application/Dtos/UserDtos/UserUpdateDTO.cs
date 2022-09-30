using System.ComponentModel.DataAnnotations;

namespace Inventory.Application.Dtos.UserDtos
{
    public class UserUpdateDTO
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "O ID é obrigatório!")]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo nome é obrigatório!")]
        [StringLength(50, ErrorMessage = "O nome deve conter no máximo 50 caracteres!")]
        public string Name { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "A senha é obrigatoria!")]
        [StringLength(8, ErrorMessage = " A senha deve conter no máximo 8 caracteres!")]
        public string Password { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Login é obrigatorio!")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O login deve conter 11 caracteres!")]
        public string Login { get; set; } = string.Empty;
    }
}
