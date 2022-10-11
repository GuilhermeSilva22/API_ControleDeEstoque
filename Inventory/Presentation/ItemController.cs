using Inventory.Application.Dtos.ItemDtos;
using Inventory.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Presentation
{
    [ApiController]
    [Route("itemController")]
    public class ItemController
    {

        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public List<ItemReadDTO> FindAll()
        {
            return _itemService.FindAll();
        }

        [HttpPost]
        public void Save([FromBody] ItemCreateDTO itemDto)
        {
            _itemService.Save(itemDto);
        }

        [HttpGet("{id}")]
        public ItemReadDTO FindById(int id)
        {
            return _itemService.FindById(id);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _itemService.Delete(id);
        }

        [HttpPut]
        public void Update([FromBody] ItemUpdateDTO userDto)
        {
            _itemService.Update(userDto);
        }
    }
}
