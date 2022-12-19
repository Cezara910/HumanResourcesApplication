using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace hr1.humanResources
{
    public partial class EmployeeStatus
    {
        public EmployeeStatus()
        {
            Employees = new HashSet<Employee>();
        }

        public int EmpStatusId { get; set; }
        [Display(Name = "Employment Status")]
        public string? EmploymentStatus { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
