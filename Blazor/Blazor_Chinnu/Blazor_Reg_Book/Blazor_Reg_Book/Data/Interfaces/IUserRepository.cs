using Blazor_Reg_Book.Data.Models;
using Blazor_Reg_Book.Data.Repository;

namespace Blazor_Reg_Book.Data.Interfaces
{
    public interface IUserRepository
    {
        User RegisterUser(string email);
        void Add(User user);

        
    }
}
