using Exercise_Razor.DTOs;
using Exercise_Razor.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise_Razor.Pages
{
    public class CreateModel : PageModel
    {

        private readonly IJobService _service;

        public CreateModel(IJobService service)
        {
            _service = service;
        }

        [BindProperty]
        public JobDto JobPost { get; set; }

        public async Task<IActionResult> OnpostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _service.AddJobAsync(JobPost);
            return RedirectToPage("Home");
        }
    }
}
