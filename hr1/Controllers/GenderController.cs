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
    public class GenderController : Controller
    {
        private readonly humanResourcesContext _context;

        public GenderController(humanResourcesContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("~/Views/Home/Genders.cshtml");
        }
        public JsonResult EmployeesByGender()
        {
            var genderGroup = _context.Employees.GroupBy(x => x.Sex).Select(x => new
            {
                Gender = x.Key,
                EmployeesCount = x.Where(e => e.EmpStatus.EmploymentStatus.Equals("Active")).Count(),
                EmployeeCountLowPerformant = x.Where(e => e.EmpStatus.EmploymentStatus.Equals("Active") && (e.PerfScore.PerformanceScore.Equals("Needs Improvement"))).Count(),
                EmployeesCountPerformant = x.Where(e => e.EmpStatus.EmploymentStatus.Equals("Active") && (e.PerfScore.PerformanceScore.Equals("Exceeds"))).Count()

            });

            EmployeesByGenderList employeesByGenderList = new EmployeesByGenderList();
            genderGroup.ToList().ForEach(d => employeesByGenderList.employeesByGenders.Add(new EmployeesByGender()
            {
                Gender = d.Gender,
                Employees = d.EmployeesCount,
                PerformantCount = d.EmployeesCountPerformant,
                NonPerformantCount = d.EmployeeCountLowPerformant

            }));

            string jsonString = JsonSerializer.Serialize(employeesByGenderList);

            return Json(jsonString);

        }
    }
}