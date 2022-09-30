using Inventory.Data.Context;
using Inventory.Data.Entities;
using Inventory.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data.Repositories
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(InventoryContext inventoryContext) : base(inventoryContext) { }

        public void Save(Item item)
        {
            this.DbSet.Add(item);
            this._context.SaveChanges();
        }

        public Item Update(Item item)
        {
            var result = this.DbSet.Update(item);
            this._context.SaveChanges();
            return result.Entity;
        }

        public Item Delete(Item item)
        {
            try
            {
                return this.Update(item);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Item> FindAll()
        {

            return this.DbSet.AsNoTracking().Where(x => !x.IsDeleted).ToList();
        }

        public Item FindById(int id)
        {
            return this.DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public bool IsExists(string codigo)
        {
            return this.DbSet.AsNoTracking().FirstOrDefault(x => x.Code == codigo && !x.IsDeleted) != null;
        }
    }
}
