using CustomAuth.Data;
using CustomAuth.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomAuth.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Employee AddEmployee(Employee e)
        {
            var addedEmployee = context.Employees.Add(e).Entity;
            context.SaveChanges();
            return addedEmployee;
        }
      

        public void DeleteEmployee(int empId)
        {
            var employee = context.Employees.Find(empId);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees.Include(e => e.Department).ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return context.Employees.Include(e => e.Department).FirstOrDefault(e => e.EmpId == id);
        }


        public Employee UpdateEmployee(Employee e)
        {
            var employee = context.Employees.Find(e.EmpId); // Fetch the existing employee
            if(employee == null)
            {
                return null;
            }
            // Update the properties
            employee.EmpName = e.EmpName;
            employee.Email = e.Email;
            employee.Phone = e.Phone;
            employee.Designation = e.Designation;
            employee.DeptId = e.DeptId;
            context.SaveChanges(); // Save changes to the database
            return employee;
        }

    }
}
