using Inventory.Data.Entities;

namespace Inventory.Data.Interfaces
{
    public interface IItemRepository
    {
        public void Save(Item item);

        public List<Item> FindAll();

        public Item Update(Item item);

        public Item Delete(Item item);

        public Item FindById(int id);

        public bool IsExists(string codigo);
    }
}
