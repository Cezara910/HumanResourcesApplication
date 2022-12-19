using System;
namespace hr1.Models
{
    public class SalaryPerDepartment
    {
        public string Department { get; set; }
        public double? AverageSalary { get; set; }
    }
    public class SalariesPerDepartment
    {
        public List<SalaryPerDepartment> salariesPerDepartments { get; set; }
        public SalariesPerDepartment()
        {
            salariesPerDepartments = new List<SalaryPerDepartment>();
        }

    }
}

