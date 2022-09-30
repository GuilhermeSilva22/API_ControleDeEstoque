using Inventory.Data.Entities;

namespace Inventory.Data.Interfaces
{
    public interface IUserRepository
    {
        public void Save(User user);
        public List<User> FindAll();
        public User Update(User user);
        public User Delete(User user);
        public User FindById(int id);
        public bool IsExists(string name);

    }
}
