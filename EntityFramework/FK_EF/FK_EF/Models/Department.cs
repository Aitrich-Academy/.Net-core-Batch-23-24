using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK_EF.Models
{
    public class Department
    {
        [Key]  // Primary key
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Department name is required")]  // Not null
        [StringLength(50)]  // Max 50 characters
        [Display(Name = "Department Name")]  // Label for UI
        public string Name { get; set; }

       
    }
}
