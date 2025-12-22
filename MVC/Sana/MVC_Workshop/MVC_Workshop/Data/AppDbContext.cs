using Microsoft.EntityFrameworkCore;
using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Job> Jobs { get; set; }

    }
}
