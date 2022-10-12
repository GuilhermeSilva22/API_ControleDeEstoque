using Inventory.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data.Context
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<Item>? Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.Location)
                    .HasMaxLength(8)
                    .HasColumnName("location");

                entity.Property(e => e.Provider)
                    .HasMaxLength(10)
                    .HasColumnName("provider");

                entity.Property(e => e.TheAmount).HasColumnName("the_amount");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.Login)
                    .HasMaxLength(11)
                    .HasColumnName("login");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(8)
                    .HasColumnName("password");
            });
        }

         
    }
}
