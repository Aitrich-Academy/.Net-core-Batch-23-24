using MachineTest_REG_BOOk.Models;
using Microsoft.AspNetCore.Mvc;

namespace MachineTest_REG_BOOk.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var userResult = HttpContext.Session.GetInt32("UserId");
            var userFirstName = HttpContext.Session.GetString("UserName");
            
           ViewBag.UserFirstName = userFirstName;

           

            return View();
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book newbook)
        {


            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            var success = _context.Books.FirstOrDefault(b => b.BookName == newbook.BookName);
            if (success != null)
            {
                return View(newbook);

            }

            var userid=HttpContext.Session.GetInt32("UserId");
            newbook.UserId=userid.Value;
            _context.Books.Add(newbook);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }


        public IActionResult ListBook()
        {
            var userResult = HttpContext.Session.GetInt32("UserId");
            var listbook = _context.Books.Where(b => b.UserId == userResult.Value).ToList();
            return View(listbook);
        }


    }
}

