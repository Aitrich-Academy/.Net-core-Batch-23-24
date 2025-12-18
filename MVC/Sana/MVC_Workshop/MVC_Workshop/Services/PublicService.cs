using MVC_Workshop.Exceptions;
using MVC_Workshop.Interfaces;
using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Services
{
    public class PublicService:IPublicService
    {
        private readonly IUserRepository _userRepository;
        public PublicService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User LoggedUSer = new User();
        bool _IsLogged = false;

        public User Register(User user)
        {
            return _userRepository.Register(user);
        }
        public User LoginJobProvider(string email, string password)
        {
            try
            {
                LoggedUSer = _userRepository.Login(email, password);
                if (LoggedUSer.Email != null)
                {

                    Console.WriteLine("Login successful!");
                    _IsLogged = true;
                    Console.WriteLine("Welcome " + LoggedUSer.FirstName);
                    return LoggedUSer;
                }
                else
                {
                    Console.WriteLine("Login failed. Please try again.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ServiceException("technical error occured");
            }
        }
        
    }
}
