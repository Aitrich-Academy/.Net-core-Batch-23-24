using Microsoft.AspNetCore.Mvc;
using MVC_HireMeNow_Workshop.Interfaces;
using MVC_HireMeNow_Workshop.Models.Entities;

namespace MVC_HireMeNow_Workshop.Controllers
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
        public ActionResult JobProviderRegistration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult JobProviderRegistration(User user)
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



        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string password)
        {
            try

            {
                var result = _publicService.LoginJobSeeker(email, password);
                if (result != null)
                {
                    HttpContext.Session.SetString("UserId", result.UserId.ToString());
                    HttpContext.Session.SetString("CompanyId", result.CompanyId.ToString());
                    return RedirectToAction("PostJob", "JobProvider");

                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }





    }
}
