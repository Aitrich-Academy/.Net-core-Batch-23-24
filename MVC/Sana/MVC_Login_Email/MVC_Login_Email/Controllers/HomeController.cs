using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Login_Email.Models;

namespace MVC_Login_Email.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}

