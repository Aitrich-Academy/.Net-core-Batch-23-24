using MVC_HireMeNow_Workshop.Exceptions;
using MVC_HireMeNow_Workshop.Interfaces;
using MVC_HireMeNow_Workshop.Models.Entities;
using MVC_HireMeNow_Workshop.Repositories;

namespace MVC_HireMeNow_Workshop.Services
{
    public class PublicService:IPublicService
    {
        private readonly IUserRepository _userRepository;

        public PublicService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User LoggedUser = new User();
        bool _isLogged = false;

        public User LoginJobSeeker(string email, string password)
        {
            try
            {

                LoggedUser = _userRepository.Login(email, password);
                if (LoggedUser.Email != null)
                {

                    Console.WriteLine("Login successful!");
                    _isLogged = true;
                    Console.WriteLine("Welcome " + LoggedUser.FirstName);
                    return LoggedUser;
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

        public User Register(User user)
        {
            return _userRepository.Register(user);
        }
    }
}
