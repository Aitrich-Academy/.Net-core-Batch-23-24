using Sevice_Repo_Demo.Models;
using Sevice_Repo_Demo.Repositories;

namespace Sevice_Repo_Demo.Services
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
            if (existing != null) return false;

            _repo.Add(user);
            _repo.Save();
            return true;
        }

        public User Login(string email, string password)
        {
            var user = _repo.GetByEmail(email);
            return (user != null && user.Password == password) ? user : null;
        }

        public User GetUser(int id) => _repo.GetById(id);

        public void UpdateUser(User user)
        {
            _repo.Update(user);
            _repo.Save();
        }
    }
}
