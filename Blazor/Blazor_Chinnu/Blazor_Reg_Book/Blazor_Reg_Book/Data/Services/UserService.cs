using Blazor_Reg_Book.Data.Interfaces;
using Blazor_Reg_Book.Data.Models;

namespace Blazor_Reg_Book.Data.Services
{
    public class UserService:IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
      public   bool RegisterUser(User user)
        {
            var existUser = _userRepository.RegisterUser(user.Email);
            if (existUser != null)
            {
                return false;
            }
            _userRepository.Add(user);
            return true;
        }

        public bool LoginUser(string email, string password)
        {
            var loguser = _userRepository.RegisterUser(email);

            if(loguser != null &&  loguser.Password==password)
            {
                return true;
            }
            return false;
        }
    }
}
