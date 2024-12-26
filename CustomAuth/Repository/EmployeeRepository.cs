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
            var departmentExists = context.Departments.Any(d => d.DeptId == e.DeptId);

            // Check DeptId exists or not
            if (!departmentExists)  
            {
                throw new ArgumentException("The specified DeptId does not exist in the Departments table.");
            }

            var addEmployee = context.Employees.Add(e).Entity;   //Add employee to context
            context.SaveChanges();   //save changes to db
            return addEmployee;
        }
      

        public bool Delete(int empId)
        {
            var employee = context.Employees.Find(empId);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Employee> GetAll()
        {
            return context.Employees.Include(e => e.Department).ToList();
        }

        public Employee GetById(int id)
        {
            var employee = context.Employees.Find(id);
            return employee;
        }


        public Employee Update(Employee e)
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
