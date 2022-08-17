using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccResearchAndDevelopmentProjectBudget
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Type { get; set; }
        public string ProjectName { get; set; }
        public string ImplementationYear { get; set; }
        public decimal? CompletionProgress { get; set; }
        public decimal? YearCompletionSchedule { get; set; }
        public decimal? TotalPlannedInvestment { get; set; }
        public decimal? TotalInvested { get; set; }
        public decimal? YearPlannedInvestment { get; set; }
        public decimal? SelfAmountRaised { get; set; }
        public decimal? YearExpenseAmount { get; set; }
        public decimal? AccumulatedExpensedAmount { get; set; }
        public decimal? YearAmountCapitalized { get; set; }
        public decimal? AccumulatedCapitalizedAmount { get; set; }
        public decimal? LastYearDevelopmentPayBalance { get; set; }
        public decimal? YearDevelopmentPayBalanceBudget { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string CompName { get; set; }
        public string MakeUnit { get; set; }
    }
}
