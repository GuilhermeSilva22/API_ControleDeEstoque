using Inventory.Application.Dtos.ItemDtos;

namespace Inventory.Application.Interfaces
{
    public interface IItemService
    {
        public void Save(ItemCreateDTO itemDto);
        public List<ItemReadDTO> FindAll();
        public void Update(ItemUpdateDTO itemDto);
        public void Delete(int id);
        public ItemReadDTO FindById(int id);
    }
}
