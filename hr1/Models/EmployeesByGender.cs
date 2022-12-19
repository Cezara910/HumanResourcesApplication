using System;
namespace hr1.Models
{
    public class EmployeesByGender
    {
        public string? Gender { get; set; }
        public int? Employees { get; set; }
        public int? PerformantCount { get; set; }
        public int? NonPerformantCount { get; set; }
    }
    public class EmployeesByGenderList
    {
        public List<EmployeesByGender> employeesByGenders { get; set; }
        public EmployeesByGenderList()
        {
            employeesByGenders = new List<EmployeesByGender>();
        }
    }
}

