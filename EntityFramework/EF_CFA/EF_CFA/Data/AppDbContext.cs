using EF_CFA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CFA.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } // Map to Products table
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string to SQL Server
            optionsBuilder.UseSqlServer("Data Source=localhost\\MSSQLSERVER03;Initial Catalog=cfa;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
