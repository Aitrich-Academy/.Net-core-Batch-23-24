using Microsoft.EntityFrameworkCore;
using MVC_HireMeNow_Workshop.Data;
using MVC_HireMeNow_Workshop.Enums;
using MVC_HireMeNow_Workshop.Interfaces;
using MVC_HireMeNow_Workshop.Models.Entities;

namespace MVC_HireMeNow_Workshop.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _context;
        private static User loggedUser = new User();

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User Login(string email, string password)
        {
            loggedUser = _context.Users.Where(e => e.Email == email && e.password == password).FirstOrDefault();
            return loggedUser;
        }

        public User Register(User user)
        {
            user.Role = Roles.JobProvider;
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User GetById(Guid userId)
        {
            //User user = _context.Users.Where(e => e.UserId == userId).Include(x => x.Skills)
            //    .Include(x => x.Experiences)
            //    .Include(x => x.Qualifications).IgnoreAutoIncludes().FirstOrDefault();
            User user = _context.Users.Where(e => e.UserId == userId).FirstOrDefault();
            return user;
        }

        public User GetLoggedUser()
        {
            return loggedUser;
        }
    }
}
