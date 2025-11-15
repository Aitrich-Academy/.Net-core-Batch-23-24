using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_MachineTest.Models;
using Razor_MachineTest.Services;

namespace Razor_MachineTest.Pages
{
    public class CreateModel : PageModel
    {
        public readonly IEmployeeService _employeeService;
        public CreateModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [BindProperty]
        public Employee Input { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _employeeService.AddEmployee(Input);
            return RedirectToPage("/Index");
        }
    }
}
