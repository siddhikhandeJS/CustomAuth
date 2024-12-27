using CustomAuth.Entities;

namespace CustomAuth.Repository
{
    public interface IDepartmentRepository
    {
        void AddDepartment(Department department);
        public IEnumerable<Department> GetAllDepartments();
    }
}
