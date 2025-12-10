using Microsoft.EntityFrameworkCore;

namespace JWT.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
        }
        public DbSet<User> Students { get; set; }
     
    }
    }

