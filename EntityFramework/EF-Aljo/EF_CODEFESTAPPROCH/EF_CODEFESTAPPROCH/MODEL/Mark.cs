using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFESTAPPROCH.MODEL
{
    internal class Mark
    {
        [Key]
        public int MarkId {  get; set; }
        [ForeignKey("student")]
        public int studentId {  get; set; }
        public student student { get; set; }
        public int M1 {  get; set; }
        public int M2 { get; set; }
        public int M3 { get; set; }


    }
}
