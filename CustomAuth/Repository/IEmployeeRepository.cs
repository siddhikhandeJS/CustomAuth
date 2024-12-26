using CustomAuth.Entities;

namespace CustomAuth.Repository
{
    public interface IEmployeeRepository 
    {
        Employee AddEmployee(Employee e);
        bool Delete(int empId);
        List<Employee> GetAll();
        Employee GetById(int empId);
        
        Employee Update(Employee e);
    }

}
