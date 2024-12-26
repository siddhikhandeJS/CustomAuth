using CustomAuth.Entities;
using CustomAuth.Service;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuth.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IDepartmentService departmentService;

        // Inject IEmployeeService via constructor
        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            this.employeeService = employeeService;
            this.departmentService = departmentService;
        }

        // Action to display all employees
        public IActionResult GetAll()
        {
            var employees = employeeService.GetAll();
            return View(employees);
        }

        // Action to render the AddForm view
        public IActionResult AddForm()
        {
            var departments = departmentService.GetAllDepartments(); //fetch all dept
            ViewBag.Departments = departments;  // pass list to view
            return View(new Employee());
        }

        //Action to handle post request
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employeeService.AddEmployee(employee);
            return RedirectToAction("GetAll");
        }

        // Action to display employee details
        public IActionResult Details(int id)
        {
            var employee = employeeService.GetById(id);
            return View(employee);
        }

        // Action to delete an employee
        public IActionResult Delete(int id)
        {
            employeeService.Delete(id);
            return RedirectToAction("GetAll");
        }



        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            var updatedEmployee = employeeService.Update(employee);
            if (updatedEmployee == null)
            {
                return NotFound();
            }
            return RedirectToAction("GetAll");
        }

        // Action to render the EditForm view
        public IActionResult EditForm(int id)
        {
            var employee = employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewBag.Departments = departmentService.GetAllDepartments();
            return View(employee);
        }

    }
}
