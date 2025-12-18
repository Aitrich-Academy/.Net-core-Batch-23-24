using Exercise_Razor.DTOs;
using Exercise_Razor.Models;

namespace Exercise_Razor.Interface
{
    public interface IUserService
    {
      bool Register(RegisterDto userdto);
       User Login(string email,string password);
    }
}
