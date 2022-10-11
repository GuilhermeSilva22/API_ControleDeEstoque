using Inventory.Data.Context;
using Inventory.Data.Entities;
using Inventory.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(InventoryContext inventoryContext) : base(inventoryContext) { }

        public void Save(User user)
        {
            this.DbSet.Add(user);
            this._context.SaveChanges();
        }

        public List<User> FindAll()
        {
            return this.DbSet.AsNoTracking().Where(x => !x.IsDeleted).ToList();
        }

        public User Update(User user)
        {
            var result = this.DbSet.Update(user);
            this._context.SaveChanges();
            return result.Entity;
        }

        public User Delete(User user)
        {
            try
            {
                return this.Update(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User FindById(int id)
        {
            return this.DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public bool IsExists(string login)
        {
            return this.DbSet.AsNoTracking().FirstOrDefault(x => x.Login.ToLower() == login.ToLower() && !x.IsDeleted) != null;
        }
    }
}
