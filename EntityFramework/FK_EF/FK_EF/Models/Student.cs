using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FK_EF.Models
{
    public class Student
    {
        [Key]  // Primary key
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [StringLength(100)]  // Limit name length
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]  // Foreign key must be filled
        [ForeignKey("Department")]  // Link to navigation property
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        [Column(TypeName = "date")]  // Store only date, no time
        [Display(Name = "Date of Birth")]
        public DateTime? DOB { get; set; }

       
    }
}

//Annotation	What it Does	Simple Meaning
//[Key] Sets as Primary Key Main ID, unique for each record
//[Required] Field must have a value	You can’t leave it empty
//[StringLength(n)] Limits string length	Type only n letters
//[Display(Name = "")] Custom name for label	Changes how the name looks in forms
//[ForeignKey("X")] Declares a foreign key for navigation X	Links to another table using ID
//[Column(TypeName = "")] Sets SQL column type	Store as only date, not datetime