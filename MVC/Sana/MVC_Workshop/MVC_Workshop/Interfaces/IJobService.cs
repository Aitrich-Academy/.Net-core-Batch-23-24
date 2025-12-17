using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Interfaces
{
    public interface IJobService
    {
        public List<Job> GetJobsposted(Guid companyId);
    }
}
