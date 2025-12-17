using Exercise_Razor.DTOs;
using Exercise_Razor.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise_Razor.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;

        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public RegisterDto Input { get; set; }

        public string Message {  get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }


        public IActionResult OnPost()
        {
            if(!ModelState.IsValid) 
                { 
                return Page();
            }

            var userSuccess=  _userService.Register(Input);
        
            if(!userSuccess)
            {
                Message = "Email already exists";
                return Page();

            }

            return RedirectToPage("Login");
        }

    }
}
