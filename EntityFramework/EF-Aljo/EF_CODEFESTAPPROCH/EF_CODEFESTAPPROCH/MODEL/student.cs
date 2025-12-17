using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFESTAPPROCH.MODEL
{
    internal class student
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string MobileNo { get; set; }
        public ICollection<Mark>marks { get; set; }=new List<Mark>();

    }
}
