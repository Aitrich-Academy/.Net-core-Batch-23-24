using Microsoft.AspNetCore.Mvc;
using MVC_Exercise_Company.Interfaces;
using MVC_Exercise_Company.Models;

namespace MVC_Exercise_Company.Controllers
{
    public class CompanyMemberController : Controller
    {
        private readonly ICompanyMemberService _companyMemberService;
        public CompanyMemberController(ICompanyMemberService companyMemberService)
        {
            _companyMemberService = companyMemberService;
        }
        public IActionResult AddMember(Guid companyId)
        {
            var companyIdStr = HttpContext.Session.GetString("CompanyId");

            if (string.IsNullOrEmpty(companyIdStr))
                return RedirectToAction("Login", "Company");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMember(CompanyMember member)
        {
            var companyIdStr = HttpContext.Session.GetString("CompanyId");

            if (string.IsNullOrEmpty(companyIdStr) || !Guid.TryParse(companyIdStr, out Guid companyId))
                return RedirectToAction("Login", "Company");

            member.CompanyId = companyId;
            _companyMemberService.AddMemberToCompany(member);

            return RedirectToAction("ListMembers");
        }
        public IActionResult ListMembers()
        {
            var companyIdStr = HttpContext.Session.GetString("CompanyId");

            if (string.IsNullOrEmpty(companyIdStr) || !Guid.TryParse(companyIdStr, out Guid companyId))
                return RedirectToAction("Login", "Company");

            var members = _companyMemberService.GetMembersByCompanyId(companyId);
            return View(members);   
        }
        [HttpGet]
        public IActionResult RemoveMember(string search)
        {
            var companyIdStr = HttpContext.Session.GetString("CompanyId");

            if (string.IsNullOrEmpty(companyIdStr) || !Guid.TryParse(companyIdStr, out Guid companyId))
                return RedirectToAction("Login", "Company");

            // Get only members of logged company
            var members = _companyMemberService.GetMembersByCompanyId(companyId);

            // Apply Search if value exists
            if (!string.IsNullOrWhiteSpace(search))
            {
                var searchText = search.Trim().ToLower();

                members = members.Where(m =>
                     m.FirstName.ToLower().Contains(searchText) ||
                     m.LastName.ToLower().Contains(searchText) ||
                     m.Designation.ToLower().Contains(searchText) ||
                     m.MemberId.ToString().ToLower().Contains(searchText)
                ).ToList();
            }

            ViewBag.Search = search;
            ViewBag.CompanyId = companyId;

            return View(members);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveMember(Guid memberId)
        {
            var companyIdStr = HttpContext.Session.GetString("CompanyId");

            if (string.IsNullOrEmpty(companyIdStr) || !Guid.TryParse(companyIdStr, out Guid companyId))
                return RedirectToAction("Login", "Company");

            if (memberId == Guid.Empty)
                return BadRequest("Data is missing");

            _companyMemberService.RemoveMember(memberId);

            return RedirectToAction("AddMember", new { companyId = companyId });
        }


    }
}

