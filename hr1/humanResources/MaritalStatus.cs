using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace hr1.humanResources
{
    public partial class MaritalStatus
    {
        public MaritalStatus()
        {
            Employees = new HashSet<Employee>();
        }

        public int MaritalStatusId { get; set; }
        [Display(Name = "Marital Status")]
        public string? MaritalDesc { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
