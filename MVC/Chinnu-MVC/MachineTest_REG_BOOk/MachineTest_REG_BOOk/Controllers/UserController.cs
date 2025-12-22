using MachineTest_REG_BOOk.Models;
using Microsoft.AspNetCore.Mvc;

namespace MachineTest_REG_BOOk.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }
      

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(User newuser)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }


            var success=_context.Users.FirstOrDefault(u=>u.Email==newuser.Email);
            if(success!=null)
            {
                return View(newuser);
                //ViewBag.Message = "User Already Exixt";
            }

            _context.Users.Add(newuser);
            _context.SaveChanges();
            return RedirectToAction("Login");

        }



        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var existuser= _context.Users.FirstOrDefault(u=> u.Email==user.Email && u.Password==user.Password);
            
            if(existuser!=null)
            {
                HttpContext.Session.SetInt32("UserId",existuser.Id);
                HttpContext.Session.SetString("UserName", existuser.FirstName);
                return RedirectToAction("Index", "Book");
            }

            return View();
        }
    }
}
