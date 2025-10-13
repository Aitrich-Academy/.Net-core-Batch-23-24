using Sevice_Repo_Demo.Models;

namespace Sevice_Repo_Demo.Repositories
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
