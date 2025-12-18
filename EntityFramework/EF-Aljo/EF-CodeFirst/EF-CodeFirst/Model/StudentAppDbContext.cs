using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Model
{
    internal class StudentAppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=LAPTOP-AV59POUI;Initial Catalog=ASUS;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

    }
}
