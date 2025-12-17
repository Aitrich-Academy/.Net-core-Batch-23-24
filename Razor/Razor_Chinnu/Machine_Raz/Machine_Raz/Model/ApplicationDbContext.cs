using Microsoft.EntityFrameworkCore;

namespace Machine_Raz.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Job> Jobs {  get; set; }
    }
}
