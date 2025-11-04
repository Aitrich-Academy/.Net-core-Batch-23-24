using Razor_ServiceRepo.Data;
using Razor_ServiceRepo.Models;

namespace Razor_ServiceRepo.Repositories
{
    public class UserRepository: IUserRepository
    {
        public readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public object GetByEmail(string email)
        {
            return _db.Users.FirstOrDefault(u => u.Email == email);
        }
        
        public void Add(Models.User user)
        {
            _db.Users.Add(user);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
        public User GetById(int id) => _db.Users.FirstOrDefault(u => u.Id == id);

    }
}
