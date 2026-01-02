using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MVC_MachineTest.Data;
using MVC_MachineTest.Models;

namespace MVC_MachineTest.Controllers
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //Edit
        public IActionResult Edit(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return View();
        }
        //delete
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
