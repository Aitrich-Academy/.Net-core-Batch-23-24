using Microsoft.AspNetCore.Mvc;
using MVC_Exercise_Company.Interfaces;
using MVC_Exercise_Company.Models;
using System;

namespace MVC_Exercise_Company.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Company company)
        {
           _companyService.CreateCompany(company);
           return RedirectToAction("Login");
            
            return View(company);
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("", "Email is required.");
                return View();
            }

            var company = _companyService.GetCompanyByEmail(email);
            if (company == null)
            {
                ModelState.AddModelError("", "Invalid email.");
                return View();
            }

            HttpContext.Session.SetString("CompanyId", company.CompanyId.ToString());
            return RedirectToAction("Profile");
        }

        public IActionResult Profile()
        {
            var companyIdStr = HttpContext.Session.GetString("CompanyId");
            if (string.IsNullOrEmpty(companyIdStr) || !Guid.TryParse(companyIdStr, out Guid companyId))
                return RedirectToAction("Login");

            var company = _companyService.GetCompanyById(companyId);
            if (company == null) return NotFound();

            return View(company);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}

