using Sevice_Repo_Demo.Data;
using Sevice_Repo_Demo.Models;

namespace Sevice_Repo_Demo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public User GetByEmail(string email) => _db.Users.FirstOrDefault(u => u.Email == email);

        public User GetById(int id) => _db.Users.FirstOrDefault(u => u.Id == id);

        public void Add(User user) => _db.Users.Add(user);

        public void Update(User user) => _db.Users.Update(user);

        public void Save() => _db.SaveChanges();
    }
}
