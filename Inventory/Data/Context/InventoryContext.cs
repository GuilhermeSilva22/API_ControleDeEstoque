using Inventory.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data.Context
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<User>? users { get; set; }
        public virtual DbSet<Item>? itens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    }
}
