using Razor_MachineTest.Data;
using Razor_MachineTest.Models;

namespace Razor_MachineTest.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        public readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }
        public Employee UpdateEmployee(Employee employee)
        {
            var existingEmployee = _context.Employees.Find(employee.EmpId);
            if (existingEmployee != null)
            {
                existingEmployee.EmpName = employee.EmpName;
                existingEmployee.Designation = employee.Designation;
                existingEmployee.Salary = employee.Salary;
                _context.SaveChanges();

            }
            return existingEmployee;

        }
        public Employee DeleteEmployee(Employee employee)
        {
            var existingEmployee = _context.Employees.Find(employee.EmpId);
            if (existingEmployee != null)
            {
                _context.Employees.Remove(existingEmployee);
                _context.SaveChanges();
                
            }
            return existingEmployee;
        }
    }
}
