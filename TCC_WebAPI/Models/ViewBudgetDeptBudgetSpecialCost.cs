using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetDeptBudgetSpecialCost
    {
        public string Year { get; set; }
        public string SubjectType { get; set; }
        public string DeptCode { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public decimal? Budget { get; set; }
        public string DeptName { get; set; }
        public decimal HappenedAmount { get; set; }
        public decimal HappeningAmount { get; set; }
        public decimal? RemainAmount { get; set; }
        public int? CbyGroup { get; set; }
    }
}
