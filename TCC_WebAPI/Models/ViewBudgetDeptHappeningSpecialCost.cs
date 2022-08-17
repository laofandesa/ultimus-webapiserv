using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetDeptHappeningSpecialCost
    {
        public int? Nd { get; set; }
        public string Deptcode { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public decimal? Amount { get; set; }
        public int? CbyGroup { get; set; }
    }
}
