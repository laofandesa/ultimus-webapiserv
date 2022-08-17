using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetDeptHappeningRunningCostDetails2
    {
        public DateTime? Nd { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public decimal? Amount { get; set; }
        public int Flag { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? CbyGroup { get; set; }
    }
}
