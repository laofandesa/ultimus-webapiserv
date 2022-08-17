using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetDeptHappenedRunningCostDetail
    {
        public int? Nd { get; set; }
        public string Deptcode { get; set; }
        public double? Amount { get; set; }
        public int Flag { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
    }
}
