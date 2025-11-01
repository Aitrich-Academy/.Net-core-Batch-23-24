using MachineTest.Model;
using MachineTest.Repository;

namespace MachineTest.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public bool Register(User user)
        {
            var existing=_repository.GetByEmail(user.Email);
            if (existing != null)
            {
                return false;
            }

                _repository.Add(user);

            _repository.Save();

                return true;
        }

        public User Login(string email, string password)

        {
            var user = _repository.GetByEmail(email);
            return (user != null && user.Password == password)? user : null;
        }
        
        public User GetUser(int id)=>_repository.GetById(id);
        public void UpdateUser(User user)
        {

            _repository.Update(user);
            _repository.Save();
        }

     
    }
}
