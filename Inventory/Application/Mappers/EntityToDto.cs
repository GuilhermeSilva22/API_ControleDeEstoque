using Inventory.Application.Dtos.ItemDtos;
using Inventory.Application.Dtos.UserDtos;
using Inventory.Data.Entities;

namespace Inventory.Application.Mappers
{
    public static class EntityToDto
    {
        public static UserReadDTO ToDto(this User User)
        {
            var UserDto = new UserReadDTO();
            if (UserDto != null)
            {
                UserDto.Id = User.Id;
                UserDto.Name = User.Name;
                UserDto.Login = User.Login;
                UserDto.Password = User.Password;
            }
            return UserDto;
        }

        public static ItemReadDTO ToDto(this Item Item)
        {
            var ItemDto = new ItemReadDTO();
            if (ItemDto != null)
            {
                ItemDto.Id = Item.Id;
                ItemDto.Code = Item.Code;
                ItemDto.TheAmount = Item.TheAmount;
                ItemDto.Description = Item.Description;
                ItemDto.Location = Item.Location;
                ItemDto.Provider = Item.Provider;
            }
            return ItemDto;
        }
    }
}
