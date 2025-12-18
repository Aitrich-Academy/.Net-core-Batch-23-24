using Exercise_Razor.DTOs;
using Exercise_Razor.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise_Razor.Pages
{
    public class DetailsModel : PageModel
    {

        private readonly IJobService _service;

        public DetailsModel(IJobService service)
        {
            _service = service;
        }

        public JobDto jobdetails { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            jobdetails = await _service.GetJobByIdAsync(id);

            if (jobdetails == null)
            {
                return NotFound();

            }
            return Page();

        }
    }
}
