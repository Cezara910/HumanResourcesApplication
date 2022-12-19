using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hr1.Models;
using hr1.humanResources;
using Microsoft.EntityFrameworkCore;

namespace hr1.Controllers;


public class HomeController : Controller
{
    private readonly humanResourcesContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, humanResourcesContext context)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        Models.EmployeeViewModel employeeViewModel = new Models.EmployeeViewModel();
        var numberOfEmployees = _context.Employees.Count();
        var numberOfDepartments = _context.Departments.Count();
        var activeEmployees = await (from e in _context.Employees
                                     where e.EmpStatus.EmploymentStatus.Equals("Active")
                                     select e).CountAsync();
        var employeesOfTheMonth = await (from e in _context.Employees
                                         where e.EmpStatus.EmploymentStatus.Equals("Active") && e.PerfScore.PerformanceScore.Equals("Exceeds")
                                         select new humanResources.Employee
                                         {
                                             EmpId = e.EmpId,
                                             Position = e.Position,
                                             EmployeeName = e.EmployeeName,
                                             MaritalStatus = e.MaritalStatus,
                                             Dept = e.Dept,
                                             PerfScore = e.PerfScore,
                                             EmpStatus = e.EmpStatus,
                                             Salary = e.Salary,
                                             Sex = e.Sex,
                                             Absences = e.Absences
                                         }).ToListAsync();
        employeeViewModel.NumberOfEmployees = numberOfEmployees;
        employeeViewModel.NumberOfDepartments = numberOfDepartments;
        employeeViewModel.ActiveEmployees = activeEmployees;
        employeeViewModel.EmployeesOfTheMonth = employeesOfTheMonth;

        return View(employeeViewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

