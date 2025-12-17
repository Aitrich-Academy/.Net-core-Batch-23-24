using Exercise_Razor.DTOs;
using Exercise_Razor.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise_Razor.Pages
{
    public class LoginModel : PageModel
    {

        private readonly IUserService _userservice;

        public LoginModel(IUserService userservice)
        {
            _userservice = userservice;

        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }


        public IActionResult OnGet()
        {
           
            return Page();
        }

        public IActionResult  OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var success =  _userservice.Login(Email,Password);

            if(success!=null)
            {
                HttpContext.Session.SetInt32("UserId",success.Id);
                HttpContext.Session.SetString("UserName",success.FirstName);
                return RedirectToPage("Home");
            }

            ErrorMessage = "Invalid Credentials Try again later!!!!";
            return Page();
        }


    }
}
