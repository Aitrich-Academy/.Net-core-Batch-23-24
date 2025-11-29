using Microsoft.EntityFrameworkCore;
using MVC_HireMeNow_Workshop.Data;
using MVC_HireMeNow_Workshop.Interfaces;
using MVC_HireMeNow_Workshop.Models.Entities;

namespace MVC_HireMeNow_Workshop.Repositories
{
    public class JobRepository:IJobRepository
    {
        private readonly AppDbContext _context;
        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Job> GetJobs()
        {
            return _context.Jobs.Include(e => e.Company).ToList();
        }

        public bool Create(Job job)
        {
            _context.Jobs.AddAsync(job);
            _context.SaveChanges();
            return true;
        }

        public List<Job> GetJobsposted(Guid cmpId)
        {
            return _context.Jobs.Where(e => e.CompanyId == cmpId).Include(e => e.Company).ToList();
        }
    }
}
