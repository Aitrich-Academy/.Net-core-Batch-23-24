using Microsoft.EntityFrameworkCore;

namespace Razor_Work_Crud.Model
{
    public class EmpDbContex:DbContext
    {
        public EmpDbContex(DbContextOptions<EmpDbContex> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; } 
    }
}
