using Sevice_Repo_Demo.Models;

namespace Sevice_Repo_Demo.Services
{
    public interface IUserService
    {
        bool Register(User user);
        User Login(string email, string password);
        User GetUser(int id);
        void UpdateUser(User user);
    }
}
