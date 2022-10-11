using Inventory.Application.Dtos.UserDtos;
using Inventory.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Presentation
{
    [ApiController]
    [Route("userController")]
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<UserReadDTO> FindAll()
        {
            return _userService.FindAll();
        }

        [HttpPost]
        public void Save([FromBody] UserCreateDTO userDto)
        {
            _userService.Save(userDto);
        }

        [HttpGet("{id}")]
        public UserReadDTO FindById(int id)
        {
            return _userService.FindById(id);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }

        [HttpPut]
        public void Update([FromBody] UserUpdateDTO userDto)
        {
            _userService.Update(userDto);
        }
    }
}
