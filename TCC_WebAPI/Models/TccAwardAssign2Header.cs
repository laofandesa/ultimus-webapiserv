using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardAssign2Header
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string UserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string AwardCategory { get; set; }
        public string ApplyCategory { get; set; }
        public int? IsProjectAward { get; set; }
        public decimal? AwardBudget { get; set; }
        public decimal? AwardAlreadyPay { get; set; }
        public decimal? AwardRemaining { get; set; }
        public decimal? AmountManagementSubc { get; set; }
        public decimal? AmountDesignSubcCurrent { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string AssignDeptCode { get; set; }
        public string AssignDeptName { get; set; }
        public string AwardsContentSummary { get; set; }
        public decimal? CurrQreference { get; set; }
        public decimal? IncludeOvertime { get; set; }
        public decimal? IncludeForeignUnitAmount { get; set; }
        public string AwardSummaryJskfj { get; set; }
        public decimal? ForeignUnitAmount { get; set; }
    }
}
