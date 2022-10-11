using Inventory.Application.Dtos.UserDtos;

namespace Inventory.Application.Interfaces
{
    public interface IUserService
    {
        public void Save(UserCreateDTO userDto);
        public List<UserReadDTO> FindAll();
        public void Update(UserUpdateDTO userDto);
        public void Delete(int id);
        public UserReadDTO FindById(int id);
    }
}
