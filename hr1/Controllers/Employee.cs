using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using hr1.humanResources;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using Microsoft.Build.Tasks;

namespace hr1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Employee : Controller
    {
        private readonly humanResourcesContext _context;

        public Employee(humanResourcesContext context)
        {
            _context = context;
        }


        // GET: Employee
        public async Task<IActionResult> Index(string searchString, string searchStringDept, string selectedLimit)
        {
            ViewData["Departments"] = new SelectList(_context.Departments, "Department1", "Department1");

            var employees = await (from e in _context.Employees
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
            if (!String.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(e => e.EmployeeName!.Contains(searchString)).ToList();
            }

            if (!String.IsNullOrEmpty(searchStringDept))
            {
                employees = employees.Where(e => e.Dept.Department1!.Contains(searchStringDept)).ToList();
            }
            if (!String.IsNullOrEmpty(selectedLimit))
            {
                employees = employees.OrderByDescending(p => p.EmpId).Take(25).ToList();
            }
            return View(employees);
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await (from e in _context.Employees
                                  where e.EmpId == id
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
                                  }).FirstOrDefaultAsync();

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            ViewData["Departments"] = new SelectList(_context.Departments, "DeptId", "Department1");
            ViewData["EmployeeStatus"] = new SelectList(_context.EmployeeStatuses, "EmpStatusId", "EmploymentStatus");
            ViewData["MaritalStatus"] = new SelectList(_context.MaritalStatuses, "MaritalStatusId", "MaritalDesc");
            ViewData["Performance"] = new SelectList(_context.Performances, "PerfScoreId", "PerformanceScore");
            ViewData["Position"] = new SelectList(_context.Positions, "PositionId", "Position1");
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeName,Sex,MaritalStatusId,PositionId,DeptId,Salary,PerfScoreId,EmpStatusId,Absences")] humanResources.Employee employee)
        {

            if (ModelState.IsValid)
            {
                var department = await (from d in _context.Departments
                                        where d.DeptId == employee.DeptId
                                        select d).FirstOrDefaultAsync();
                var position = await (from p in _context.Positions
                                      where p.PositionId == employee.PositionId
                                      select p).FirstOrDefaultAsync();
                var maritalStatus = await (from m in _context.MaritalStatuses
                                           where m.MaritalStatusId == employee.MaritalStatusId
                                           select m).FirstOrDefaultAsync();
                var performanceScore = await (from s in _context.Performances
                                              where s.PerfScoreId == employee.PerfScoreId
                                              select s).FirstOrDefaultAsync();
                var employeeStatus = await (from e in _context.EmployeeStatuses
                                            where e.EmpStatusId == employee.EmpStatusId
                                            select e).FirstOrDefaultAsync();

                var employeeData = new humanResources.Employee
                {
                    EmployeeName = employee.EmployeeName,
                    Sex = employee.Sex,
                    MaritalStatus = maritalStatus,
                    Position = position,
                    Dept = department,
                    Salary = employee.Salary,
                    PerfScore = performanceScore,
                    EmpStatus = employeeStatus,
                    Absences = employee.Absences
                };
                _context.Add(employeeData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["Departments"] = new SelectList(_context.Departments, "DeptId", "Department1");
            ViewData["EmployeeStatus"] = new SelectList(_context.EmployeeStatuses, "EmpStatusId", "EmploymentStatus");
            ViewData["MaritalStatus"] = new SelectList(_context.MaritalStatuses, "MaritalStatusId", "MaritalDesc");
            ViewData["Performance"] = new SelectList(_context.Performances, "PerfScoreId", "PerformanceScore");
            ViewData["Position"] = new SelectList(_context.Positions, "PositionId", "Position1");

            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpId,EmployeeName,Sex,MaritalStatusId,PositionId,DeptId,Salary,PerfScoreId,EmpStatusId,Absences")] humanResources.Employee employee)
        {
            if (id != employee.EmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await (from e in _context.Employees
                                  where e.EmpId == id
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
                                  }).FirstOrDefaultAsync();
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmpId == id);
        }
    }
}
