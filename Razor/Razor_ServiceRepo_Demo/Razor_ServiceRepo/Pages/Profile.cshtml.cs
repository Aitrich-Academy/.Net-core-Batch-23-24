using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_ServiceRepo.Models;
using Razor_ServiceRepo.Services;

namespace Razor_ServiceRepo.Pages
{
    public class ProfileModel : PageModel
    {
        public readonly IUserService _service;
        public ProfileModel(IUserService service)
        {
            _service = service;
        }
        public User User { get; set; }
        public void OnGet()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId.HasValue)
            {
                User = _service.GetUser(userId.Value);
            }
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/EditProfile");
        }
    }
}
