using Razor_ServiceRepo.Models;

namespace Razor_ServiceRepo.Services
{
    public interface IUserService
    {
        bool Register(User user);
        User Login(string email, string password);
        User GetUser(int id);

    }
}
