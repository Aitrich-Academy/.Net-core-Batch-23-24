using Razor_ServiceRepo.Models;
using Razor_ServiceRepo.Repositories;

namespace Razor_ServiceRepo.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }
        public bool Register(User user)
        {
            var existing = _repo.GetByEmail(user.Email);
            if (existing != null)
            {
                return false; // Email already registered
            }
            _repo.Add(user);
            _repo.Save();
            return true;
        }
        public User Login(string email, string password)
        {
            var user = _repo.GetByEmail(email) as User;
            if (user != null && user.Password == password)
            {
                return user;
            }
            return null;
        }
        public User GetUser(int id)
        {
            return _repo.GetById(id);
        }
    }
}
