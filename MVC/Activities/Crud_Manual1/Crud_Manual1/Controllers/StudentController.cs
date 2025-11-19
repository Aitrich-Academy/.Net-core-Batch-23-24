using Crud_Manual1.Models;
using Crud_Manual1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Manual1.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var students = _service.GetAll();
            return View(students);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _service.Add(student);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var student = _service.Get(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _service.Update(student);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var student = _service.Get(id);
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
