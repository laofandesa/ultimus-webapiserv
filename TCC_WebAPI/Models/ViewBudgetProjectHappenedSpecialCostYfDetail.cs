using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetProjectHappenedSpecialCostYfDetail
    {
        public string ProjectCode { get; set; }
        public int? Code { get; set; }
        public string Expensename { get; set; }
        public string Name { get; set; }
        public decimal? Amount { get; set; }
        public int Flag { get; set; }
        public DateTime? AccountDate { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? CbyGroup { get; set; }
    }
}
