using MVC_Workshop.Interfaces;

namespace MVC_Workshop.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public List<Models.Entities.Job> GetJobsposted(Guid companyId)
        {
            return _jobRepository.GetJobsposted(companyId);
        }
    }
}
