using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardAssign2PersonLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string AwardCategory { get; set; }
        public string PersonLoginName { get; set; }
        public string UserIdentity { get; set; }
        public string PersonRealName { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManagerLoginName { get; set; }
        public string ProjectManagerRealName { get; set; }
        public string ProjectManagerIdentity { get; set; }
        public decimal? ContractPrice { get; set; }
        public decimal? AmountAlreadyReceivables { get; set; }
        public decimal? AmountReceivablesCurrentQ { get; set; }
        public string OptimalContent { get; set; }
        public decimal? WorkEvaluation { get; set; }
        public decimal? Adjustment { get; set; }
        public decimal? Amount { get; set; }
        public string ResponsibilityBookNumber { get; set; }
        public string ResponsibilityScope { get; set; }
        public string ResponsibilityScopeRemark { get; set; }
        public decimal? HoursSafe { get; set; }
        public decimal? AnnualPlanHoursSafe { get; set; }
        public decimal? SafetyAssessment { get; set; }
        public decimal? RiskGuarantee { get; set; }
        public string BasicWorkContent { get; set; }
        public string AwardsContentSummary { get; set; }
        public decimal? AwardBase { get; set; }
        public string Remark { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public string IsFanPin { get; set; }
        public string ResponsibilityScopeCode { get; set; }
        public decimal? YearHourSafe { get; set; }
    }
}
