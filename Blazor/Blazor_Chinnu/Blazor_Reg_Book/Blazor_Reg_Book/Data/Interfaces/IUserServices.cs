using Blazor_Reg_Book.Data.Models;
using Microsoft.Extensions.Logging;

namespace Blazor_Reg_Book.Data.Interfaces
{
    public interface IUserServices
    {
        bool RegisterUser( User user);

        bool LoginUser(string email, string password);
    }
}
