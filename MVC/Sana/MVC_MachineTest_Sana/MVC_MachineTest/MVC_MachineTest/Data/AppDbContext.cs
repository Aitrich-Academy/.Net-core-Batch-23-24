using Microsoft.EntityFrameworkCore;
using MVC_MachineTest.Models;

namespace MVC_MachineTest.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options) { }
        public DbSet<Employee>   EmployeeDetails { get; set; }
    }
}
