using Razor_MachineTest.Models;
using Razor_MachineTest.Repositories;

namespace Razor_MachineTest.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }
        public Employee AddEmployee(Employee employee)
        {
            return _employeeRepository.AddEmployee(employee);
        }
        public Employee UpdateEmployee(Employee employee)
        {
            return _employeeRepository.UpdateEmployee(employee);
        }
        public Employee DeleteEmployee(Employee employee)
        {
            return _employeeRepository.DeleteEmployee(employee);

        }
    }
}
