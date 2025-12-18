using Blazor_Reg_Book.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Reg_Book.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

      public   DbSet<User> Users { get; set; }

      public   DbSet<Book> Books { get; set; }

    }
}
