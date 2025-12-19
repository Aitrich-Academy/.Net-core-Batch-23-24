using Microsoft.AspNetCore.Mvc;
using MVC_MachineTest.Data;
using MVC_MachineTest.Models;

namespace MVC_MachineTest.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _dbContext;
        public EmployeeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       
        public IActionResult Index()
        {
           var employees = _dbContext.EmployeeDetails.ToList();
            return View(employees);
            if (employees != null)
            { 
                int count = employees.Count();
               
            }

            //var searchesignation =_dbContext.EmployeeDetails.FirstOrDefault( E =>
            //    E.Designation == employees.Designation);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _dbContext.EmployeeDetails.Add(employee);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
