using MVC_HireMeNow_Workshop.Models.Entities;

namespace MVC_HireMeNow_Workshop.Interfaces
{
    public interface IPublicService
    {
        public User LoginJobSeeker(string email, string password);
        public User Register(User newJobSeeker);
    }
}
