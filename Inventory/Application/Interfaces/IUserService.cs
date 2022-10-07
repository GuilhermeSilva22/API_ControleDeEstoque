using Inventory.Application.Dtos.UserDtos;

namespace Inventory.Application.Interfaces
{
    public interface IUserService
    {
        public void Save(UserCreateDTO userCreateDto);
        public List<UserReadDTO> FindAll();
        public UserUpdateDTO Update();
        public void Delete(int id);
        public UserReadDTO FindById(int id);
    }
}
