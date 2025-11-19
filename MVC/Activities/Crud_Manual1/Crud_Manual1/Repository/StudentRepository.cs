using Crud_Manual1.Data;
using Crud_Manual1.Models;

namespace Crud_Manual1.Repository
{
    public class StudentRepository: IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAll() => _context.StudentsData.ToList();

        public Student GetById(int id) => _context.StudentsData.Find(id);

        public void Add(Student student)
        {
            _context.StudentsData.Add(student);
            _context.SaveChanges();
        }

        public void Update(Student student)
        {
            _context.StudentsData.Update(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = _context.StudentsData.Find(id);
            if (student != null)
            {
                _context.StudentsData.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
