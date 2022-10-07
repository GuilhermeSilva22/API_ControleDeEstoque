using Inventory.Application.Dtos.ItemDtos;

namespace Inventory.Application.Interfaces
{
    public interface IServiceItem
    {
        public void Save(ItemCreateDTO itemDto);
        public List<ItemReadDTO> FindAll();
        public ItemUpdateDTO Update();
        public void Delete(int id);
        public ItemReadDTO FindById(int id);
    }
}
