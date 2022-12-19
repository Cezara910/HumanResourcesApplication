using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using hr1.humanResources;
using hr1.Migrations;
using hr1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static NuGet.Packaging.PackagingConstants;

namespace hr1.Controllers
{


    [Authorize]
    public class SalariesController : Controller
    {
        private readonly humanResourcesContext _context;

        public SalariesController(humanResourcesContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("~/Views/Home/Salaries.cshtml");
        }

        // GET: Salaries
        public JsonResult SalariesPerDept()
        {
            var deptGroup = from e in _context.Employees
                            group e by new
                            {
                                e.Dept.Department1
                            } into depts
                            select new
                            {
                                SalaryAverage = depts.Where(e => e.EmpStatus.EmploymentStatus.Equals("Active")).Average(e => e.Salary),
                                depts.Key.Department1
                            };
            SalariesPerDepartment salariesPerDepartment = new SalariesPerDepartment();
            deptGroup.ToList().ForEach(d => salariesPerDepartment.salariesPerDepartments.Add(new SalaryPerDepartment()
            {
                Department = d.Department1,
                AverageSalary = d.SalaryAverage
            }));

            string jsonString = JsonSerializer.Serialize(salariesPerDepartment);

            return Json(jsonString);

        }

    }
}