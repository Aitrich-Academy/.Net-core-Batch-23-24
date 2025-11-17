using Microsoft.EntityFrameworkCore;
using Razor_MachineTest.Models;

namespace Razor_MachineTest.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
