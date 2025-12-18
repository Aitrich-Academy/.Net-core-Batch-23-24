using Microsoft.AspNetCore.Mvc;
using MVC_Workshop.Interfaces;
using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Controllers
{
    public class PublicController : Controller
    {
        private readonly IPublicService _publicService;
        public PublicController(IPublicService publicService)
        {
            _publicService = publicService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult JobProviderRegistration()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult JobProviderRegistration(User user)
        {
            try
            {
                _publicService.Register(user);
                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            try
            {
                var result = _publicService.LoginJobProvider(email, password);
                if (result != null)
                {
                   HttpContext.Session.SetString("UserId", result.UserId.ToString());
                   HttpContext.Session.SetString("CompanyId", result.CompanyId.ToString());
                    return RedirectToAction("JobPost", "JobProvider");
                }
                ModelState.AddModelError("", "Invalid login attempt.");
                return View();
            }
            catch
            {
                return View();
            }
        }

    }
}
