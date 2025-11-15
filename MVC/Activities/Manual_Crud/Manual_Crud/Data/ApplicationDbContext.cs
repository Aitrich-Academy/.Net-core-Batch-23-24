using Manual_Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Manual_Crud.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
