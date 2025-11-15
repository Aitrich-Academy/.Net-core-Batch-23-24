using System.ComponentModel.DataAnnotations;

namespace Razor_MachineTest.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public double Salary { get; set; }
    }
}
