using System.ComponentModel.DataAnnotations;

namespace Inventory.Application.Dtos.ItemDtos
{
    public class ItemCreateDTO
    {

        [Required(ErrorMessage = "O código é obrigatorio!")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "O  código deve conter 6 caracteres!")]
        public string Code { get; set; } = string.Empty;

        [Required(ErrorMessage = "A quantidade é obrigatoria!!")]
        public int TheAmount { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatorio!")]
        [StringLength(50, ErrorMessage = "A quantidade máxima de caracteres é 50!")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo locação é obrigatorio!")]
        [StringLength(8, ErrorMessage = "O número máximo de caracteres é 8!")]
        public string Location { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo fornecedor é obrigatório!")]
        [StringLength(10, ErrorMessage = "O tamanho máximo é 10!")]
        public string Provider { get; set; } = string.Empty;
    }
}
