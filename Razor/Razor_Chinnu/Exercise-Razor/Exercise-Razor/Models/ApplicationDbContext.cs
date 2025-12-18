using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Exercise_Razor.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
           public DbSet<Job> Jobs { get; set; }
           public DbSet<User> Users { get;set; }
        

    }
}
