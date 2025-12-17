using Machine_Raz.Dto;
using Machine_Raz.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Machine_Raz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IJobService _service;

        public IndexModel(IJobService service)
        {
            _service = service;
        }

        public List<JobDto> JobList { get; set; }

        public void OnGet()
        {
            JobList = _service.GetAllJobs();
        }
    }
}
