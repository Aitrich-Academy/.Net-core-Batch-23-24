using MachineTest.Data;
using MachineTest.Model;

namespace MachineTest.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _db;
        public UserRepository(AppDbContext db)
        {
            _db = db;
        }
        public User GetByEmail(string email) => _db.Users.FirstOrDefault(u => u.Email == email);
        public User GetById(int id) => _db.Users.FirstOrDefault(u => u.Id == id);
        public void Add(User user) => _db.Users.Add(user);
        public void Update(User user)=> _db.Users.Update(user);
        public void Save()=> _db.SaveChanges();

    }
}
