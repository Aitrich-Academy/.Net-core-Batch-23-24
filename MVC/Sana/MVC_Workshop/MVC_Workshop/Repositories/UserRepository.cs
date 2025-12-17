using MVC_Workshop.Data;
using MVC_Workshop.Enums;
using MVC_Workshop.Interfaces;
using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly AppDbContext _context;
        private static User loggedUser = new User();
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                loggedUser = user;
            }
            return user;
        }
        public User Register(User newJobProvider)
        {
            newJobProvider.Role = Roles.JobProvider;
            _context.Users.Add(newJobProvider);
            _context.SaveChanges();
            return newJobProvider;
        }
        public User GetById(Guid uid)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == uid);
        }
       
    }
}
