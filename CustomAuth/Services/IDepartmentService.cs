using CustomAuth.Entities;

namespace CustomAuth.Service
{
    public interface IDepartmentService
    {
       Department AddDepartment(Department department);
        List<Department> GetAllDepartments();
       
    }
}
