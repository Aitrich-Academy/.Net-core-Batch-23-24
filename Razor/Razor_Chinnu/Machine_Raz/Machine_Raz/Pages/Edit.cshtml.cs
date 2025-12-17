using Machine_Raz.Dto;
using Machine_Raz.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Machine_Raz.Pages
{
    public class EditModel : PageModel
    {

        private readonly IJobService _service;

        public EditModel(IJobService service)
        {
            _service = service;
        }

        [BindProperty]
        public JobDto JobPost {  get; set; }
        public IActionResult OnGet(int id)
        {
            JobPost=_service.GetJobById(id);

            if(JobPost == null)
            {
                return NotFound();
            }
            return Page();
        }


        public IActionResult OnPost()
        {
            _service.UpdateJob(JobPost.Id, JobPost);
            return RedirectToPage("Index");
        }
    }
}
