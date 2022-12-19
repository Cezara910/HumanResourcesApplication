using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace hr1.humanResources
{
    public partial class Performance
    {
        public Performance()
        {
            Employees = new HashSet<Employee>();
        }

        public int PerfScoreId { get; set; }
        [Display(Name = "Performance Score")]
        public string? PerformanceScore { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
