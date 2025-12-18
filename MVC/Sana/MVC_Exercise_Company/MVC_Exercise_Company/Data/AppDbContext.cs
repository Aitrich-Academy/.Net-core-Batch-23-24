using Microsoft.EntityFrameworkCore;
using MVC_Exercise_Company.Models;

namespace MVC_Exercise_Company.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyMember> CompanyMembers { get; set; }
    }
}
