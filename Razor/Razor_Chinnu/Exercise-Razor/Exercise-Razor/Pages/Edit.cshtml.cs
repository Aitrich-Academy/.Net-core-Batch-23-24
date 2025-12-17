using Exercise_Razor.DTOs;
using Exercise_Razor.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise_Razor.Pages
{
    public class EditModel : PageModel
    {
        private readonly IJobService _service;

        public EditModel(IJobService service)
        {
            _service = service;
        }

        [BindProperty]
        public JobDto JobPost { get; set; }


        public async Task<ActionResult> OnGetAsync(int id)
        {
            JobPost = await _service.GetJobByIdAsync(id);
            if (JobPost == null)
            {
                return NotFound();
            }
            return Page();
        }



        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateJobAsync(JobPost.Id, JobPost);
            return RedirectToPage("Home");
        }

    }
}
