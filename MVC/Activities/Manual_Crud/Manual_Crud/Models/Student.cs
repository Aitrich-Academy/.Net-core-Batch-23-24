using System.ComponentModel.DataAnnotations;

namespace Manual_Crud.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
