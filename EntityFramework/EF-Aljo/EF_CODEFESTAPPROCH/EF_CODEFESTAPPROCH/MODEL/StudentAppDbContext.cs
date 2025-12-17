using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_CODEFESTAPPROCH.MODEL
{
    internal class StudentAppDbContext:DbContext
    {
        public DbSet<student> Students { get; set; }
        public DbSet<Mark>marks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-AV59POUI;Initial Catalog=Exam;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
