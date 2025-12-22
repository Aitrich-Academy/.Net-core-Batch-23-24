using MVC_Workshop.Interfaces;
using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetById(Guid guid)
        {
            return _userRepository.GetById(guid);
        }
    }
}
