using Microsoft.EntityFrameworkCore;

namespace Blazor_New.Data.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
   public DbSet<Book> books { get;set; }
    }
}
