using System.ComponentModel.DataAnnotations;

namespace MVC_MachineTest.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
