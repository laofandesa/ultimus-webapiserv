using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetProcessWageAccountAmount
    {
        public int Id { get; set; }
        public int? Fid { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public int? Year { get; set; }
        public string BudgetName { get; set; }
        public string BudgetCode { get; set; }
        public string CostType { get; set; }
        public decimal? LastYearBudget { get; set; }
        public decimal? LastYearAmount { get; set; }
        public decimal? ThisYearBudget { get; set; }
        public decimal? ThisYearAmount { get; set; }
        public decimal? NextYearBudget { get; set; }
        public decimal? NextYearChange { get; set; }
        public string Note { get; set; }
        public string DeptCode2 { get; set; }
    }
}
