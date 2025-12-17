using Exercise_Razor.DTOs;
using Exercise_Razor.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise_Razor.Pages
{
    public class HomeModel : PageModel
    {
        private readonly IJobService _service;

        public HomeModel(IJobService service)
        {
            _service = service;
        }

        public string UserName {  get; set; }
      


        public List<JobDto> JobPosts { get; set; }
        public async Task OnGetAsync()
        {

            UserName = HttpContext.Session.GetString("UserName");
            JobPosts = await _service.GetAllJobsAsync();
        }
    }
}
