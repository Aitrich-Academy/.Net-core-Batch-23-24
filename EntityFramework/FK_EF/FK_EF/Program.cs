using FK_EF.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            // Add a Department
            var dept = new Department { Name = "chinees" };
            context.Departments.Add(dept);
            context.SaveChanges();

            // Add a Student linked to the above department
            var student = new Student { FullName = "Navi", DepartmentId = dept.DepartmentId , DOB = new DateTime(2000, 5, 20) };
            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully with Department");
        }
    }
}