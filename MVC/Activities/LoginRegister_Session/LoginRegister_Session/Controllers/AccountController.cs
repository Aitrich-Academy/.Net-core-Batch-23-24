using AutoMapper;
using LoginRegister_Session.Data;
using LoginRegister_Session.DTOs;
using LoginRegister_Session.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginRegister_Session.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AccountController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Register
        public IActionResult Register() => View();

        // POST: Register
        [HttpPost]
        public IActionResult Register(UserDTO dto)
        {
            var user = _mapper.Map<User>(dto);
            _context.Users.Add(user);
            _context.SaveChanges();
           // ViewBag.Message = "Registered Successfully!";
            return RedirectToAction("Login");
        }

        // GET: Login
        public IActionResult Login() => View();

        // POST: Login
        [HttpPost]
        public IActionResult Login(UserDTO dto)
        {
            var user = _context.Users.FirstOrDefault(u =>
                u.Username == dto.Username && u.Password == dto.Password);

            if (user != null)
            {
                HttpContext.Session.SetString("username",user.Username); 
                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Invalid Login";
            return View();
        }

        // GET: Dashboard
        public IActionResult Dashboard()
        {
            var username = HttpContext.Session.GetString("username");
            if (username == null)
                return RedirectToAction("Login");

            ViewBag.Username = username;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
