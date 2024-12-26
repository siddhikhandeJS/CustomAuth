using CustomAuth.Entities;
using CustomAuth.Repository;
using CustomAuth.Service;

namespace Assignment1.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        // Constructor injection for repository
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Employee AddEmployee(Employee employee)
        {
            var addEmployee = employeeRepository.AddEmployee(employee);   //calls repo method
            return addEmployee;
        }

        public bool Delete(int employeeId)
        {
            return employeeRepository.Delete(employeeId);
        }

        public List<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

        public Employee GetById(int employeeId)
        {
            return employeeRepository.GetById(employeeId);
        }

        public Employee Update(Employee employee)
        {
            return employeeRepository.Update(employee);            
        }       
    }
}
