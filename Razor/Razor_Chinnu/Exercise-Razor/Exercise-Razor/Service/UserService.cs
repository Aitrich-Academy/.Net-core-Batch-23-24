using AutoMapper;
using Exercise_Razor.DTOs;
using Exercise_Razor.Interface;
using Exercise_Razor.Models;

namespace Exercise_Razor.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userrepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userrepository, IMapper mapper)
        {
            _userrepository = userrepository;
            _mapper = mapper;
        }

        public bool Register(RegisterDto registerdto)
        {
          var existinguser=  _userrepository.GetUserByEmail(registerdto.Email); 

            if (existinguser != null)
            {
                return false;
            }

            var newuser = _mapper.Map<User>(registerdto);
             _userrepository.AddUser(newuser);

            return true;

        }



        public User Login(string email,string password)
        {

            var user= _userrepository.GetUserByEmail(email);

            if (user != null && user.Password==password)
            {
                return user;
            }
            return null;
          
            

        }
    }
}
