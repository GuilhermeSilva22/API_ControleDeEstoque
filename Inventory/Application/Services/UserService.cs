using Inventory.Application.Dtos.UserDtos;
using Inventory.Application.Interfaces;
using Inventory.Application.Mappers;
using Inventory.Data.Interfaces;

namespace Inventory.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Save(UserCreateDTO userDto)
        {
            var user = userDto.ToEntity();
            if (_userRepository.IsExists(user.Login))
            {
                throw new Exception("O usuário já existe!");
            }
            _userRepository.Save(user);
        }

        public List<UserReadDTO> FindAll()
        {
            var users = _userRepository.FindAll();
            List<UserReadDTO> result = new List<UserReadDTO>();
            foreach (var user in users)
            {
                UserReadDTO userDto = user.ToDto();
                result.Add(userDto);
            }
            return result;
        }

        public void Update(UserUpdateDTO userDto)
        {
            var user = userDto.ToEntity();
            _userRepository.Update(user);
        }

        public void Delete(int id)
        {
            var user = _userRepository.FindById(id);
            user.IsDeleted = true;
            _userRepository.Delete(user);
        }

        public UserReadDTO FindById(int id)
        {
            return _userRepository.FindById(id).ToDto();
        }
    }
}
