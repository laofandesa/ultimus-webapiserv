using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetBasic
    {
        public int Id { get; set; }
        public string BudgetName { get; set; }
        public string BudgetCode { get; set; }
        public int? Orderby { get; set; }
        public int? BudgetType { get; set; }
        public int? BudgetFlag { get; set; }
        public int? IsTotal { get; set; }
        public int? ValidGroup { get; set; }
        public int? IsViewTotal { get; set; }
        public int? TotalOrderby { get; set; }
        public string BdgUrl { get; set; }
        public int? FormatType { get; set; }
        public int? Year { get; set; }
        public int? Batch { get; set; }
        public int? LevelType { get; set; }
        public int? IsEditThisYearBudget { get; set; }
        public int? IsEditThisYearUsed { get; set; }
        public string LinkFieldValue { get; set; }
        public int? IsUpdateValue { get; set; }
    }
}
