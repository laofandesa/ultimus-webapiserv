using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetProjectBudgetSpecialCost
    {
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? CostChanged { get; set; }
        public string ProjTypeDesc { get; set; }
        public string ExpenseName { get; set; }
        public int? CbyGroup { get; set; }
        public decimal? HappenedAmount { get; set; }
        public decimal? HappeningAmount { get; set; }
        public decimal? DemainAmount { get; set; }
    }
}
