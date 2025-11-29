using MVC_HireMeNow_Workshop.Interfaces;
using MVC_HireMeNow_Workshop.Models.Entities;
using MVC_HireMeNow_Workshop.Repositories;

namespace MVC_HireMeNow_Workshop.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //public User getById(Guid userId)
        //{
        //    return _userRepository.GetById(userId);
        //}

        public User GetById(Guid guid)
        {
            return _userRepository.GetById(guid);
        }
    }
}
