using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace hr1.humanResources
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        [Display(Name = "Name")]
        public string? EmployeeName { get; set; }
        public string? Sex { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? PositionId { get; set; }
        public int? DeptId { get; set; }
        public int? Salary { get; set; }
        public int? PerfScoreId { get; set; }
        public int? EmpStatusId { get; set; }
        public int? Absences { get; set; }

        
        public virtual Department? Dept { get; set; }
        public virtual EmployeeStatus? EmpStatus { get; set; }
        public virtual MaritalStatus? MaritalStatus { get; set; }
        public virtual Performance? PerfScore { get; set; }
        public virtual Position? Position { get; set; }
    }
}
