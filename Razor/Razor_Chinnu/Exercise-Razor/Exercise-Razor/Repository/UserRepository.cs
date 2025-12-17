using Exercise_Razor.Interface;
using Exercise_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise_Razor.Repository
{

  

    
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public User GetUserByEmail(string email)
        {
            return  _db.Users.FirstOrDefault(u => u.Email == email);
        }


     


        public  void AddUser(User user)
        {
            _db.Users.Add(user);
             _db.SaveChanges();
        }
    }
}
