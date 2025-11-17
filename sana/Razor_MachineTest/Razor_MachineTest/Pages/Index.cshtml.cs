using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_MachineTest.Models;
using Razor_MachineTest.Services;

namespace Razor_MachineTest.Pages
{
    public class IndexModel : PageModel
    {
        public readonly IEmployeeService _employeeService;
        public IndexModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [BindProperty(SupportsGet = true)]
        public List<Employee> Employees { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<Employee> FilteredEmployees { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchDesignation { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Count { get; set; }

        public void OnGet()
        {
            if (!string.IsNullOrEmpty(SearchDesignation))
            {
               FilteredEmployees = _employeeService.GetAllEmployees()
                    .Where(e => e.Designation != null && e.Designation.Contains(SearchDesignation, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                if (!string.IsNullOrEmpty(Count) && int.TryParse(Count, out int countValue))
                {
                    FilteredEmployees = FilteredEmployees.Take(countValue).ToList();
                }
                Employees = FilteredEmployees;
                return;
            }

            Employees = _employeeService.GetAllEmployees();

        }
    }
}
