using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_MachineTest.Models;
using Razor_MachineTest.Services;

namespace Razor_MachineTest.Pages
{
    public class EditModel : PageModel
    {
        public readonly IEmployeeService _employeeService;
        public EditModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [BindProperty]
        public Employee Input { get; set; }
        public void OnGet()
        {

            var employee = _employeeService.GetAllEmployees()
                .FirstOrDefault(e => e.EmpId == Convert.ToInt32(Request.Query["id"]));
            if (employee != null)
            {
                Input = employee;
            }


        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _employeeService.UpdateEmployee(Input);

            return RedirectToPage("/Index");
        }
    }
}
