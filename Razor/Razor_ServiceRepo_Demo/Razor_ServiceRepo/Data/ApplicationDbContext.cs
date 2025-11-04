using Microsoft.EntityFrameworkCore;

namespace Razor_ServiceRepo.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }
        public DbSet<Razor_ServiceRepo.Models.User> Users { get; set; }
    }
}
