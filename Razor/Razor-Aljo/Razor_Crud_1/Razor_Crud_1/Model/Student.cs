using System.ComponentModel.DataAnnotations;

namespace Razor_Crud_1.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
