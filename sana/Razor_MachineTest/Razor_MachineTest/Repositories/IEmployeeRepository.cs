using Razor_MachineTest.Models;

namespace Razor_MachineTest.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Employee DeleteEmployee(Employee employee);
    }
}
