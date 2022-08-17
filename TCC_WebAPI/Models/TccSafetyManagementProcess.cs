using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSafetyManagementProcess
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public string AwardCategory { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public string ContractType { get; set; }
        public DateTime? StartWorkDate { get; set; }
        public DateTime? PlanCompleteDate { get; set; }
        public decimal? ProjectProgressStatus { get; set; }
        public decimal? HoursTotal { get; set; }
        public string HoursSafe { get; set; }
        public decimal? SafetyAuditScore { get; set; }
        public decimal? CurrentRequestAmount { get; set; }
        public decimal? ForeignUnitAmount { get; set; }
        public decimal? AssignAmountTotal { get; set; }
        public string ProjectReamrk { get; set; }
        public decimal? AppAuditAmount { get; set; }
        public decimal? AppForeignUnitAmount { get; set; }
        public decimal? AppCurrentAssignAmount { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public int? AssignStatus { get; set; }
        public DateTime? AssignDate { get; set; }
        public int? RejectTimes { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public decimal? YearAwardBudget { get; set; }
        public decimal? YearPayment { get; set; }
        public decimal? YearBalance { get; set; }
        public decimal? CurrentQapproveMoney { get; set; }
        public decimal? CurrentLeftMoney { get; set; }
        public decimal? AfterCurrentApproveLeftMoney { get; set; }
    }
}
