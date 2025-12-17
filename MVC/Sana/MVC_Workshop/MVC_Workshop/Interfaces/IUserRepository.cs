using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Interfaces
{
    public interface IUserRepository
    {
        User Login(string email, string password);
        User Register(User newJobProvider);
        User GetById(Guid uid);
       
    }
}
