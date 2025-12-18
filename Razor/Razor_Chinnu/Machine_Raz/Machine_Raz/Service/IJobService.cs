using Machine_Raz.Dto;

namespace Machine_Raz.Service
{
    public interface IJobService
    {
      List<JobDto>  GetAllJobs();

     void AddJob(JobDto job);

     JobDto GetJobById(int id);

        void UpdateJob(int Id, JobDto JobPost);
    }
}
