using Microsoft.AspNetCore.Mvc;
using PartialViewDemo.Models;

namespace PartialViewDemo.Controllers
{
    public class StudentsController : Controller
    {
        private static readonly List<Student> _students = new()
{
        new Student { Id = 1, Name = "Anu", Course = "C#" },
        new Student { Id = 2, Name = "Balu", Course = "ASP.NET Core" },
        new Student { Id = 3, Name = "Chris", Course = "SQL" }
};


        public IActionResult Index()
        {
            // Send the list to the view
            return View(_students);
        }
    }
}
