namespace Inventory.Application.Dtos.UserDtos
{
    public class UserReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty ;
        public string Login { get; set; } = string.Empty ;
    }
}
