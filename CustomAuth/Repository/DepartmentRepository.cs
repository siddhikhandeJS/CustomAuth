using CustomAuth.Data;
using CustomAuth.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomAuth.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext context;

        public DepartmentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Department AddDepartment(Department department)
        {
            var addDept = context.Add(department).Entity;
            context.SaveChanges();
            return addDept;
        }

        public List<Department> GetAllDepartments()
        {
            return context.Departments.ToList();
        }
    }
}
