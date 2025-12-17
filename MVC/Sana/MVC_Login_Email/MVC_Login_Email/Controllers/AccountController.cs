using Microsoft.AspNetCore.Mvc;
using MVC_Login_Email.Helper;
using MVC_Login_Email.Models;
using MVC_Login_Email.Service;

namespace MVC_Login_Email.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IEmailService _emailService;

        public AccountController(AppDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            var newUser = new User
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Email and Password are required";
                return View();
            }

            var user = _context.Users
                .FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null)
            {
                ViewBag.Error = "Invalid Login";
                return View();
            }         
            try
            {
                MailRequest mailRequest = new MailRequest();
                mailRequest.ToEmail = user.Email;
                mailRequest.Subject = "Login Successful";
                mailRequest.Body = $@"<h2>Hello {user.Name}</h2>
                                <p>You logged in successfully.</p>
                                <p>Date & Time: {DateTime.Now}</p>";
            _emailService.SendEmail(mailRequest);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Login Failed");
            }

            return RedirectToAction("Dashboard", "Home");
        }
        

    }
}

