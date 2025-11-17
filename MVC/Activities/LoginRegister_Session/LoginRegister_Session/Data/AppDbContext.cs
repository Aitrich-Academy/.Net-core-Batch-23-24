using LoginRegister_Session.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginRegister_Session.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
