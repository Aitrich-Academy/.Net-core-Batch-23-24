using MachineTest.Model;

namespace MachineTest.Repository
{
    public interface IUserRepository
    {
        User GetByEmail(string email);
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Save();
    }
}
