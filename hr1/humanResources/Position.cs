using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace hr1.humanResources
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public int PositionId { get; set; }
        [Display(Name = "Position")]
        public string? Position1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
