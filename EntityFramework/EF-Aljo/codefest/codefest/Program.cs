using codefest.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

internal class Program
{
    private static void Main(string[] args)
    {
        var context = new StudentsMarksAppDbContext();
        while (true)
        {
            Console.WriteLine("/nChoose Options !");
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.View Student");
            Console.WriteLine("3.Update Student");
            Console.WriteLine("4.Delete Student");
            Console.WriteLine("5.Add Marks");
            Console.WriteLine("6.View Marks");
            Console.WriteLine("7.Exit");
            Console.WriteLine("Enter Choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                //case 2: ViewStudent(); break;
                //case 3: UpdateStudent(); break;
                //case 4: DeleteStudent(); break;
                //case 5: AddMarks(); break;
                //case 6: ViewMarks(); break;
                case 7: return;
                default: Console.WriteLine("Wrong Choice"); break;
            }
        }
    }
    static void AddStudent()
    {
        var context = new StudentsMarksAppDbContext();
        {
            Console.WriteLine("Enter Your name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Date of Birth (dd/MM/yyyy):");
            DateOnly dob = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            var student = new Student
            {
                Name = name,
                Age = age,
                Birthday = dob

            };
            context.students.Add(student);
            context.SaveChanges();
            Console.WriteLine("Student Added");
        }



    }
}
 


