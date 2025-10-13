using Microsoft.EntityFrameworkCore;
using Sevice_Repo_Demo.Models;

namespace Sevice_Repo_Demo.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
