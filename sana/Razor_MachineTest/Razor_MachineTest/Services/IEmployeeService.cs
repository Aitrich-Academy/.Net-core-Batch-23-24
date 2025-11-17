using Razor_MachineTest.Models;

namespace Razor_MachineTest.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Employee DeleteEmployee(Employee employee);
    }
}
