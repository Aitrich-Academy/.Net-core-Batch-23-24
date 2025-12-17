using System.ComponentModel.DataAnnotations;

namespace Razor_Work_Crud.Model
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public string Job { get; set; }
        [Required]
        public string JobName { get; set; }
        [Required]
        public decimal Salary { get; set; }

    }
}
