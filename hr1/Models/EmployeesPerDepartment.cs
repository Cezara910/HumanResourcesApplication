using System;
namespace hr1.Models
{
    public class EmployeesPerDepartment
    {
        public string? Department { get; set; }
        public int? Employees { get; set; }
        public int? PerformantEmployeesCount { get; set; }
    }
    public class EmployeesPerDepartmentList
    {
        public List<EmployeesPerDepartment> employeesPerDepartments { get; set; }
        public EmployeesPerDepartmentList()
        {
            employeesPerDepartments = new List<EmployeesPerDepartment>();
        }
    }
}

