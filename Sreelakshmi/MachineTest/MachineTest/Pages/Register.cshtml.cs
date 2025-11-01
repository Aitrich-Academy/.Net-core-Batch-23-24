using MachineTest.Model;
using MachineTest.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MachineTest.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _service;
        public RegisterModel(IUserService service)
        {
            _service = service;
        }

        [BindProperty]
        public User Input {  get; set; }
        public string Message { get; set; }

        public void OnGet()
        { }
        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
                return Page();
            var success=_service.Register(Input);
            if(!success)
            {
                Message = "Email Already Registered";
                return Page();
            }
            return RedirectToPage("/Login");
        }
    }
        
    }

