
using CustomAuth.Entities;
using CustomAuth.Repository;

namespace CustomAuth.Service
{
    public class DepartmentService  : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        public void AddDepartment(Department department)
        {
            departmentRepository.AddDepartment(department);
         
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return departmentRepository.GetAllDepartments();
        }

    }
}
