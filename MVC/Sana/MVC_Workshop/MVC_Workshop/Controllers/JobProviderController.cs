using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC_Workshop.Interfaces;
using MVC_Workshop.Models.DTOs;
using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Controllers
{
    public class JobProviderController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IJobRepository _jobRepository;
        private readonly IJobService _jobService;
        private readonly IUserRepository _userRepository;

        public JobProviderController(IMapper mapper, IJobRepository jobRepository, IJobService jobService, IUserRepository userRepository)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
            _jobService = jobService;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult JobPost()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult JobPost(JobDTO jobDtO)
        {
            var uid = HttpContext.Session.GetString("UserId");
            User user = _userRepository.GetById(new Guid(uid));

            jobDtO.CompanyId = user.CompanyId;
            var job = _mapper.Map<Job>(jobDtO);
            bool result = _jobRepository.Create(job);

            TempData["Message"] = "Successfully posted Job";
            return RedirectToAction("AllJobs");
        }

        public IActionResult AllJobs()
        {
            var uid = HttpContext.Session.GetString("UserId");



            User user = _userRepository.GetById(new Guid(uid));
            Guid cmpId = (Guid)user.CompanyId;
            List<Job> jobs = _jobService.GetJobsposted(cmpId);

            return View(jobs);
        }
    }
}
