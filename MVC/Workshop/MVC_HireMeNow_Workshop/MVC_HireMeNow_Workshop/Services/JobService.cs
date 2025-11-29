using MVC_HireMeNow_Workshop.Interfaces;
using MVC_HireMeNow_Workshop.Models.Entities;

namespace MVC_HireMeNow_Workshop.Services
{
    public class JobService:IJobService
    {
        private readonly IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public List<Job> GetJobs()
        {
            return _jobRepository.GetJobs();
        }
        public List<Job> GetJobsposted(Guid cmpId)
        {
            return _jobRepository.GetJobsposted(cmpId);
        }
    }
}
