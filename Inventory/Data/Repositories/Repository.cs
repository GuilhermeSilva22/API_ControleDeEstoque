using Inventory.Data.Context;
using Inventory.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data.Repositories
{
    public class Repository<TEntity> where TEntity : BaseEntity
    {
        protected readonly InventoryContext _context;
        protected DbSet<TEntity> DbSet { get; }

        public Repository(InventoryContext InventoryContext)
        {
            _context = InventoryContext;
            DbSet = _context.Set<TEntity>();
        }
    }
}
