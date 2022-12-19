using System;
using hr1.humanResources;

namespace hr1.Models
{
	public class EmployeeViewModel
	{
		public int NumberOfEmployees { get; set; }
		public int NumberOfDepartments { get; set; }
        public int ActiveEmployees { get; set; }
        public List<Employee>? EmployeesOfTheMonth { get; set; }
    }
}

