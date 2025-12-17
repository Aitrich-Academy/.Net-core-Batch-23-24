using Machine_Raz.Dto;
using Machine_Raz.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Machine_Raz.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IJobService _service;

        public CreateModel(IJobService service)
        {
            _service = service;
        }
        [BindProperty]
        public JobDto jobdto {  get; set; }


        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _service.AddJob(jobdto);
            return RedirectToPage("/Index");


        }
    }
}
