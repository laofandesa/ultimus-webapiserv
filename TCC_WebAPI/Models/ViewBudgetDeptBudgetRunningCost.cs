using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetDeptBudgetRunningCost
    {
        public string Year { get; set; }
        public string SubjectType { get; set; }
        public string DeptCode { get; set; }
        public decimal? Budget { get; set; }
        public string DeptName { get; set; }
        public decimal HappenedAmount { get; set; }
        public decimal HappeningAmount { get; set; }
        public decimal? RemainAmount { get; set; }
    }
}
