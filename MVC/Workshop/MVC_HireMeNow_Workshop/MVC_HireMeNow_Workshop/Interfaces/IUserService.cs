using MVC_HireMeNow_Workshop.Models.Entities;

namespace MVC_HireMeNow_Workshop.Interfaces
{
    public interface IUserService
    {
        User GetById(Guid guid);
    }
}
