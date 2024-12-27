using CustomAuth.Entities;

namespace CustomAuth.Repository
{
    public interface IEmployeeRepository 
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }

}
