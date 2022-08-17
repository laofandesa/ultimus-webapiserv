using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetProjectHappeningSpecialCostFyfDetail
    {
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ApplicationName { get; set; }
        public int? ApplicationCode { get; set; }
        public string ExpenseName { get; set; }
        public decimal? Amount { get; set; }
        public int Flag { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? CbyGroup { get; set; }
    }
}
