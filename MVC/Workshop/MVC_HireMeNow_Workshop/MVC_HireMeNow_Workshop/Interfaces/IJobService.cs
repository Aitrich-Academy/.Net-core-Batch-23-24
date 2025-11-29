using MVC_HireMeNow_Workshop.Models.Entities;

namespace MVC_HireMeNow_Workshop.Interfaces
{
    public interface IJobService
    {
        public List<Job> GetJobs();
        public List<Job> GetJobsposted(Guid cmpId);
    }
}
