using CustomAuth.Entities;
using CustomAuth.Repository;
using CustomAuth.Service;

namespace CustomAuth.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return employeeRepository.GetEmployeeById(id);
        }

        public Employee AddEmployee(Employee employee)
        {
            return employeeRepository.AddEmployee(employee);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            return employeeRepository.UpdateEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            employeeRepository.DeleteEmployee(id);
        }
    }
}
