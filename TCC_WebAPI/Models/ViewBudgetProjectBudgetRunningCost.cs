using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetProjectBudgetRunningCost
    {
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? Budget { get; set; }
        public string ProjTypeDesc { get; set; }
        public double HappenedAmount { get; set; }
        public decimal HappeningAmount { get; set; }
        public double? RemainAmount { get; set; }
    }
}
