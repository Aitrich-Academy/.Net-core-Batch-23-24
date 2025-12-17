using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Interfaces
{
    public interface IUserService
    {
        User GetById(Guid guid);
    }
}
