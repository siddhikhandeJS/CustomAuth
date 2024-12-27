using CustomAuth.Entities;

namespace CustomAuth.Service
{
    public interface IDepartmentService
    {
       void AddDepartment(Department department);
       IEnumerable<Department> GetAllDepartments();

    }
}
