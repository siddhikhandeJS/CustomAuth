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

        public void AddDepartment(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return context.Departments.ToList();
        }
    }
}
