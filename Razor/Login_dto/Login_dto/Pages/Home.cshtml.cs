using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Login_dto.Pages
{
    public class HomeModel : PageModel
    {
        public string WelcomeMessage { get; set; }
        public bool IsLoggedIn { get; set; }


        public IActionResult OnGet()
        {
            var userName = HttpContext.Session.GetString("UserName");
            if (!string.IsNullOrEmpty(userName))
            {
                WelcomeMessage = $"Welcome {userName}!";
                IsLoggedIn = true;
            }
            else
            {
                WelcomeMessage = "Welcome! Please login or register.";
                IsLoggedIn = false;
            }


            return Page();
        }
        public IActionResult OnPostLogout()
        {
            HttpContext.Session.Clear();
            return RedirectToPage("/Login");
        }
    }
}
