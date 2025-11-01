using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sevice_Repo_Demo.Models;
using Sevice_Repo_Demo.Services;

namespace Sevice_Repo_Demo.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly IUserService _service;
        public ProfileModel(IUserService service) { _service = service; }

        public User User { get; set; }

        public void OnGet()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId != null) 
                User = _service.GetUser(userId.Value);
        }

        public IActionResult OnPost() => RedirectToPage("/EditProfile");
    }
}
