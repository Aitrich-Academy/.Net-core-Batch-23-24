using MachineTest.Model;
using Microsoft.EntityFrameworkCore;

namespace MachineTest.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
        public DbSet<User>Users { get; set; }
    }
}
