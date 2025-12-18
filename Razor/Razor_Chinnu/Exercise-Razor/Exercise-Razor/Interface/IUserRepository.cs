using Exercise_Razor.Models;

namespace Exercise_Razor.Interface
{
    public interface IUserRepository
    {
        
        User GetUserByEmail(string email);
        void AddUser(User user);

       
    }
}
