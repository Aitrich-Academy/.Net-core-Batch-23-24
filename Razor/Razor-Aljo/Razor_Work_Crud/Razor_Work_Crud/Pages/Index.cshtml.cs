using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Work_Crud.Model;

namespace Razor_Work_Crud.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Work_Crud.Model.EmpDbContex _context;

        public IndexModel(Razor_Work_Crud.Model.EmpDbContex context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
