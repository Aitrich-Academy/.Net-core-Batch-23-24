using Machine_Raz.Model;

namespace Machine_Raz.Repository
{
    public interface IJobRepository
    {
        List<Job> GetAllJob();
        void AddNewJob(Job addjob);
        Job GetById(int id);
        void UpdateJob(int Id,Job updatejob);
    }
}
