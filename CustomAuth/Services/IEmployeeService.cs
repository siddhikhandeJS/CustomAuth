using CustomAuth.Entities;

namespace CustomAuth.Service
{
    public interface IEmployeeService
    {
        Employee AddEmployee(Employee employee);
        bool Delete(int employeeId);
        List<Employee> GetAll();
        Employee GetById(int employeeId);
        Employee Update(Employee employee);
    }
}
