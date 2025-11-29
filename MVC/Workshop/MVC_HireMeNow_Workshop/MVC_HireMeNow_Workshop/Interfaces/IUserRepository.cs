using MVC_HireMeNow_Workshop.Models.Entities;

namespace MVC_HireMeNow_Workshop.Interfaces
{
    public interface IUserRepository
    {
        User GetLoggedUser();
        User Login(string email, string password);
        User Register(User user);
        User GetById(Guid uid);


    }
}
