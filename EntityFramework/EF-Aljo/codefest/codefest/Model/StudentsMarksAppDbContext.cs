using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefest.Model
{
    public class StudentsMarksAppDbContext:DbContext
    {
      public  DbSet<Student> students { get; set; }
        public DbSet<Marks> marks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-AV59POUI;Initial Catalog=skullcandie;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
