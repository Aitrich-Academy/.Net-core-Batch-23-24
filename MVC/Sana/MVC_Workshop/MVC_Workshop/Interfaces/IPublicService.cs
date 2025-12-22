using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Interfaces
{
    public interface IPublicService
    {
        public User Register(User newJobProvider);
        public User LoginJobProvider(string email, string password);
    }
}
