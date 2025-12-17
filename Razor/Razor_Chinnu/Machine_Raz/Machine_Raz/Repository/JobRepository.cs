using Machine_Raz.Model;
using Microsoft.EntityFrameworkCore;

namespace Machine_Raz.Repository
{
    public class JobRepository:IJobRepository
    {

        private readonly ApplicationDbContext _context;

        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }


      public  List<Job> GetAllJob()
        {
            var job = _context.Jobs.ToList();
            return job; 
        }

        public void AddNewJob(Job addjob)
        {
            _context.Jobs.Add(addjob);
            _context.SaveChanges();
        }

        public Job GetById(int id)
        {
            var jobById = _context.Jobs.Find(id);
            return jobById;
        }


       public void UpdateJob(int Id, Job updatejob)
        {
            var existingjob = _context.Jobs.Find(Id);

            if(existingjob ==null)  return;

            _context.Entry(existingjob).State=EntityState.Detached;

            var updatedjob = updatejob;
            updatedjob.Id= Id;

            _context.Jobs.Add(updatedjob);
            _context.Entry(updatedjob).State=EntityState.Modified;
            _context.SaveChanges() ;

        }
    }
}

