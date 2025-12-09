using WebApi_Login.Models;

namespace WebApi_Login.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User Login(string username, string password);
        bool UserExists(string username);
        void Save();
    }
}
