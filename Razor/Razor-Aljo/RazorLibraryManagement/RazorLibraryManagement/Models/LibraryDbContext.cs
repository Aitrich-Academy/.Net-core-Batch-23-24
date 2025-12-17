using Microsoft.EntityFrameworkCore;

namespace RazorLibraryManagement.Models
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options):base(options)
        {
            
        }
        public DbSet<BookModel> BookTable { get; set; }
    }
}
