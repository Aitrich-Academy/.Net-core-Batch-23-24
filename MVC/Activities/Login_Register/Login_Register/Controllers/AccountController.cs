using AutoMapper;
using Login_Register.Models;
using Microsoft.AspNetCore.Mvc;

namespace Login_Register.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AccountController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Registration GET
        public IActionResult Register()
        {
            return View();
        }

        // Registration POST
        
        public IActionResult Register(UserDto userDto)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(userDto);
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(userDto);
        }

        // Login GET
        public IActionResult Login()
        {
            return View();
        }

        // Login POST
        [HttpPost]
        public IActionResult Login(UserDto userDto)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == userDto.Email && u.Password == userDto.Password);
            if (user != null)
            {
                return RedirectToAction("Dashboard");
            }
            ModelState.AddModelError("", "Invalid login attempt.");
            return View(userDto);
        }

        // Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
