using CustomAuth.Entities;

namespace CustomAuth.Repository
{
    public interface IDepartmentRepository
    {
        Department AddDepartment(Department department);

        
        List<Department> GetAllDepartments();
    }
}
