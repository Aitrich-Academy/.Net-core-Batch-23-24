using Razor_ServiceRepo.Models;

namespace Razor_ServiceRepo.Repositories
{
    public interface IUserRepository
    {
        object GetByEmail(string email);
        User GetById(int id);

        void Add(User user);
        void Save();
        
    }
}
