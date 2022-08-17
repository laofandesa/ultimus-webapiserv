using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFixedAssetInvestmentProjectsTemp
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Type { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string InvestmentCategory { get; set; }
        public string InvestmentDirection { get; set; }
        public string ProjectPhase { get; set; }
        public string ProjectLocation { get; set; }
        public string ProjectContent { get; set; }
        public decimal? PlanTotalAmount { get; set; }
        public decimal? TotalOwnFunds { get; set; }
        public string InvestmentEnterprises { get; set; }
        public decimal? TotalnvestmentOfTheEnterprise { get; set; }
        public decimal? ProportionOfTheEnterprise { get; set; }
        public decimal? ActualCompleteAmount { get; set; }
        public decimal? CumulativeCompleteAmount { get; set; }
        public decimal? PlanAmount { get; set; }
        public decimal? OwnFunds { get; set; }
        public decimal? LoanFunds { get; set; }
        public decimal? OtherFunds { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string InvestmentRate { get; set; }
        public string InvestmentBasis { get; set; }
        public string Remark { get; set; }
        public int? AlreadyOrNew { get; set; }
        public decimal? HoldingProportionStart { get; set; }
        public decimal? HoldingProportionEnd { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string Investment1 { get; set; }
        public string Investment2 { get; set; }
        public string Investment3 { get; set; }
        public string Industry { get; set; }
        public decimal? BudgetTzamount { get; set; }
        public decimal? ActTzamount { get; set; }
        public decimal? ActTzljamount { get; set; }
        public string ActTzljamountPct { get; set; }
        public decimal? PlanLjamount { get; set; }
        public string PlanLjamountPct { get; set; }
        public decimal? PlanAmountBudget { get; set; }
        public decimal? Yjysamount { get; set; }
        public string MakeUnit { get; set; }
        public decimal? ProjectAmountTotal { get; set; }
        public decimal? ZczbpartAmount { get; set; }
    }
}
