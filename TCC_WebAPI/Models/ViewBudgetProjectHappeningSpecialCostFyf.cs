using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetProjectHappeningSpecialCostFyf
    {
        public string ProjectCode { get; set; }
        public decimal? Amount { get; set; }
        public string ExpenseName { get; set; }
        public int? CbyGroup { get; set; }
    }
}
