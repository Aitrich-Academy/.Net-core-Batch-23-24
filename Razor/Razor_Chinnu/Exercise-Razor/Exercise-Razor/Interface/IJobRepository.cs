using Exercise_Razor.Models;

namespace Exercise_Razor.Interface
{
    public interface IJobRepository
    {
        public Task<List<Job>> GetAlljobsAsync();

        public Task AddJobAsync(Job job);

        public Task<Job> GetJobByIdAsync(int id);

        public Task DeleteJobAsync(int id);


        public Task UpdateJobAsync(int id, Job job);
    }
}
