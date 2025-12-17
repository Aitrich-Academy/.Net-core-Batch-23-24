using BlazorActivity.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorActivity.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }  
    }

}
