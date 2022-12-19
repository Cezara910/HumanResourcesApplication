using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using hr1.humanResources;
using hr1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace hr1.Controllers
{

    [Authorize]
    public class DepartmentsController : Controller
    {
        private readonly humanResourcesContext _context;

        public DepartmentsController(humanResourcesContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("~/Views/Home/Departments.cshtml");
        }
        public IActionResult Performance()
        {
            return View("~/Views/Home/Performance.cshtml");
        }

        public JsonResult EmployeesPerDept()
        {
            var deptGroup = _context.Employees.GroupBy(x => x.Dept.Department1).Select(x => new { Department = x.Key, EmployeesCount = x.Where(e => e.EmpStatus.EmploymentStatus.Equals("Active")).Count() });

            EmployeesPerDepartmentList employeesPerDepartment = new EmployeesPerDepartmentList();
            deptGroup.ToList().ForEach(d => employeesPerDepartment.employeesPerDepartments.Add(new EmployeesPerDepartment()
            {
                Department = d.Department,
                Employees = d.EmployeesCount
            }));

            string jsonString = JsonSerializer.Serialize(employeesPerDepartment);

            return Json(jsonString);

        }
        public JsonResult PerformantEmployeesPerDept()
        {
            var deptGroup = _context.Employees.GroupBy(x => x.Dept.Department1).Select(x =>
            new
            {
                Department = x.Key,
                EmployeesCount = x.Where(e => e.EmpStatus.EmploymentStatus.Equals("Active")).Count(),
                PerformantEmployeesCount = x.Where(e => e.EmpStatus.EmploymentStatus.Equals("Active") && (e.PerfScore.PerformanceScore.Equals("Exceeds"))).Count()
            });

            EmployeesPerDepartmentList employeesPerDepartment = new EmployeesPerDepartmentList();
            deptGroup.ToList().ForEach(d => employeesPerDepartment.employeesPerDepartments.Add(new EmployeesPerDepartment()
            {
                Department = d.Department,
                Employees = d.EmployeesCount,
                PerformantEmployeesCount = d.PerformantEmployeesCount
            }));

            string jsonString = JsonSerializer.Serialize(employeesPerDepartment);

            return Json(jsonString);

        }
    }
}





