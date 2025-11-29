using MVC_HireMeNow_Workshop.Models.Entities;

namespace MVC_HireMeNow_Workshop.Interfaces
{
    public interface IJobRepository
    {
        bool Create(Job job);
        public List<Job> GetJobsposted(Guid cmpId);

        List<Job> GetJobs();
    }
}
