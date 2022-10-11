using Inventory.Application.Dtos.ItemDtos;
using Inventory.Application.Mappers;
using Inventory.Data.Interfaces;

namespace Inventory.Application.Services
{
    public class ItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void Save(ItemCreateDTO itemDto)
        {
            var item = itemDto.ToEntity();
            if (_itemRepository.IsExists(item.Code))
            {
                throw new Exception("O item já está cadastrado!");
            }
            _itemRepository.Save(item);
        }

        public List<ItemReadDTO> FindAll()
        {
            var itens = _itemRepository.FindAll();
            List<ItemReadDTO> result = new List<ItemReadDTO>();
            foreach (var item in itens)
            {
                ItemReadDTO itemDto = item.ToDto();
                result.Add(itemDto);
            }
            return result;
        }

        public void Update(ItemUpdateDTO itemDto)
        {
            var item = itemDto.ToEntity();
            _itemRepository.Update(item);
        }

        public void Delete(int id)
        {
            var item = _itemRepository.FindById(id);
            item.IsDeleted = true;
            _itemRepository.Delete(item);
        }

        public ItemReadDTO FindByID(int id)
        {
            return _itemRepository.FindById(id).ToDto();
        }
    }
}
