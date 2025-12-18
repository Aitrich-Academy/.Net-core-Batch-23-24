using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefest.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
        public ICollection<Marks> Marks { get; set; }=new List<Marks>();
    }
}
