using MachineTest.Model;
using MachineTest.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MachineTest.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly IUserService _Service;
        public ProfileModel(IUserService Service)
        {
            _Service = Service;
        }

        public User User { get; set; }
        public string UserId { get; private set; }

        public void OnGet()
        {
            var userid = HttpContext.Session.GetInt32(UserId);
            if (userid != null)
            {
                User = _Service.GetUser(userid.Value);
            }
        }
    }
}
    

