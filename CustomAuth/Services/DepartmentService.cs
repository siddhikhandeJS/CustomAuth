
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

        public Department AddDepartment(Department department)
        {
            var addDept = departmentRepository.AddDepartment(department);
            return addDept;
         
        }

        public List<Department> GetAllDepartments()
        {
            return departmentRepository.GetAllDepartments();
        }
    }
}
