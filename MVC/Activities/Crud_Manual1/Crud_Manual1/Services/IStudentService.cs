using Crud_Manual1.Models;

namespace Crud_Manual1.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student Get(int id);
        void Add(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
