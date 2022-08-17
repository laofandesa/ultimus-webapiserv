using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDeptAnnualBudget
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string ItemCode { get; set; }
        public string Item3 { get; set; }
        public string ItemSubCode { get; set; }
        public decimal? Budget { get; set; }
        public string Using { get; set; }
        public decimal? HasedBudget { get; set; }
        public decimal? RemainBudget { get; set; }
    }
}
