using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sevice_Repo_Demo.Services;

namespace Sevice_Repo_Demo.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _service;
        public LoginModel(IUserService service) { _service = service; }

        [BindProperty] public string Email { get; set; }
        [BindProperty] public string Password { get; set; }
        public string ErrorMessage { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            var user = _service.Login(Email, Password);
            if (user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.Id);
                HttpContext.Session.SetString("UserName", user.FirstName);
                return RedirectToPage("/Dashboard");
            }

            ErrorMessage = "Invalid credentials.";
            return Page();
        }
    }
}
