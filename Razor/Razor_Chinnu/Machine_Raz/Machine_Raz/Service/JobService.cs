using AutoMapper;
using Machine_Raz.Dto;
using Machine_Raz.Model;
using Machine_Raz.Repository;

namespace Machine_Raz.Service
{
    public class JobService
    {
        private readonly IJobRepository _repository;
        private readonly IMapper _mapper;

        public JobService(IJobRepository repository,IMapper mapper)
        { 
            _mapper = mapper;
            _repository = repository;
        }

        public List<JobDto> GetAllJobs()
        {
            var job = _repository.GetAllJob();
            return _mapper.Map<List<JobDto>>(job);
        }

        public void AddJob(JobDto job)
        {
            var addjob=_mapper.Map<Job>(job);
            _repository.AddNewJob(addjob);
        }

       public JobDto GetJobById(int id)
        {
            var getjobByid=_repository.GetById(id);
            return _mapper.Map<JobDto>(getjobByid);
        }


        public void UpdateJob(int Id, JobDto JobPost)
        {
            var updatejob=_mapper.Map<Job>(JobPost);
            _repository.UpdateJob(Id, updatejob);
        }
    }
}
