using Inventory.Application.Dtos.ItemDtos;
using Inventory.Application.Dtos.UserDtos;
using Inventory.Data.Entities;

namespace Inventory.Application.Mappers
{
    public static class DtoToEntity
    {
        public static User ToEntity(this UserCreateDTO UserDTO)
        {
            var user = new User();
            if (user != null)
            {
                user.Name = UserDTO.Name;
                user.Login = UserDTO.Login;
                user.Password = UserDTO.Password;
            }
            return user;
        }

        public static User ToEntity(this UserUpdateDTO UserDTO)
        {
            var user = new User();
            if (user != null)
            {
                user.Id = UserDTO.Id;
                user.Name = UserDTO.Name;
                user.Password = UserDTO.Password;
                user.Login = UserDTO.Login;

            }
            return user;
        }

        public static Item ToEntity(this ItemCreateDTO ItemDto)
        {
            Item Item = new Item();
            if (Item != null)
            {
                Item.Code = ItemDto.Code;
                Item.TheAmount = ItemDto.TheAmount;
                Item.Description = ItemDto.Description;
                Item.Location = ItemDto.Location;
                Item.Provider = ItemDto.Provider;
            }
            return Item;
        }

        public static Item ToEntity(this ItemUpdateDTO ItemDto)
        {
            Item Item = new Item();
            if (Item != null)
            {
                Item.Id = ItemDto.Id;
                Item.Code = ItemDto.Code;
                Item.TheAmount = ItemDto.TheAmount;
                Item.Description = ItemDto.Description;
                Item.Location = ItemDto.Location;
                Item.Provider = ItemDto.Provider;
            }
            return Item;
        }

    }
}
