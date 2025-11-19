using Crud_Manual1.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Manual1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> StudentsData { get; set; }
    }
}
