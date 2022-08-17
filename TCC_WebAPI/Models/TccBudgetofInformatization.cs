using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetofInformatization
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Type { get; set; }
        public string SerialNum { get; set; }
        public string ProjectName { get; set; }
        public string ExpandColI { get; set; }
        public string YearofProject { get; set; }
        public decimal? TotalPlannedInvestment { get; set; }
        public decimal? PreviousYearsPct { get; set; }
        public decimal? PreviousYearsAmount { get; set; }
        public decimal? PlanCompletionProgress { get; set; }
        public decimal? PlanAmount { get; set; }
        public decimal? FixedAmount { get; set; }
        public decimal? IntangibleAmount { get; set; }
        public decimal? InformationAmount { get; set; }
        public string Remark { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string MakeUnit { get; set; }
        public int? IsEditThisYearUsed { get; set; }
        public int? IsEditThisYearBudget { get; set; }
    }
}
