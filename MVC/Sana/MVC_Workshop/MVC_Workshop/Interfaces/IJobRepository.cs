using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Interfaces
{
    public interface IJobRepository
    {
        bool Create(Job job);
        public List<Job> GetJobsposted(Guid cmpId);
    }
}
