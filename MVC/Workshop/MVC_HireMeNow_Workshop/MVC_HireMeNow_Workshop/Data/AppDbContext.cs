using Microsoft.EntityFrameworkCore;
using MVC_HireMeNow_Workshop.Models.Entities;
using MVC_HireMeNow_Workshop.Models.DTOs;

namespace MVC_HireMeNow_Workshop.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       

        public virtual DbSet<Company> Companies { get; set; }

       
        

        public virtual DbSet<Job> Jobs { get; set; }

       

        

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           

           

            

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasOne(d => d.Company).WithMany(p => p.Jobs)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Jobs__CompanyId");

                entity.HasOne(d => d.CreatedUser).WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Jobs__CreatedByUser");
            });

           
           

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasOne(d => d.Company).WithMany(p => p.Users)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__User__Company");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                e.State == EntityState.Modified);
            foreach (var entry in entries)
            {
                if (entry.Entity.GetType() == typeof(Job))
                {
                    entry.Property("UpdatedDate").CurrentValue = DateTime.Now;
                    if (entry.State == EntityState.Added)
                    {
                        entry.Property("CreatedDate").CurrentValue = DateTime.Now;
                    }
                }
            }
            return base.SaveChanges();
        }
        public DbSet<MVC_HireMeNow_Workshop.Models.DTOs.CompanyMemberDTO> CompanyMemberDTO { get; set; } = default!;
    }
}
