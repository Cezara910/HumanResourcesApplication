using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace hr1.humanResources
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DeptId { get; set; }
        [Display(Name = "Department")]
        public string? Department1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
