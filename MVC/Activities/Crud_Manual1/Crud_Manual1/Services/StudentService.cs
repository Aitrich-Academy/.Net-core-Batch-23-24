using Crud_Manual1.Models;
using Crud_Manual1.Repository;

namespace Crud_Manual1.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetAll() => _repo.GetAll();

        public Student Get(int id) => _repo.GetById(id);

        public void Add(Student student) => _repo.Add(student);

        public void Update(Student student) => _repo.Update(student);

        public void Delete(int id) => _repo.Delete(id);
    }
}
