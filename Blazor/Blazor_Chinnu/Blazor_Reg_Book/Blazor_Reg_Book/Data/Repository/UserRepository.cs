using Blazor_Reg_Book.Data.Interfaces;
using Blazor_Reg_Book.Data.Models;

namespace Blazor_Reg_Book.Data.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public User  RegisterUser(string email)
        {
            var existuser=_appDbContext.Users.FirstOrDefault(u=>u.Email == email);
            return existuser;
        }

        public void Add(User user)
        {
            _appDbContext.Users.Add(user);
            _appDbContext.SaveChanges();
        }

    }
}
