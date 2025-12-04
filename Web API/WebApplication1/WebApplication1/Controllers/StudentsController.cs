using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new List<Student>
    {
        new Student { Id = 1, Name = "Akhil", Age = 21 },
        new Student { Id = 2, Name = "Anu", Age = 22 },
        new Student { Id = 3, Name = "Binu", Age = 26 },
        new Student { Id = 4, Name = "Gokul", Age = 24 },
        new Student { Id = 5, Name = "Donal", Age = 30 }
    };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return student == null ? NotFound() : Ok(student);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();

            students.Remove(student);
            return Ok("Deleted");
        }
    }
}
