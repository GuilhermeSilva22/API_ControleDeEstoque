namespace Inventory.Application.Dtos.ItemDtos
{
    public class ItemReadDTO
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public int TheAmount { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Provider { get; set; } = string.Empty;

    }
}
