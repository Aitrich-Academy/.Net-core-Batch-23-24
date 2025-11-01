using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_ServiceRepo.Pages
{
    public class DashboardModel : PageModel
    {
        public string UserName { get; set; }

        public void OnGet()
        {
            UserName = HttpContext.Session.GetString("UserName");
            
        }
    }
}
