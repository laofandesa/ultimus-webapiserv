using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSpecialAwardHeader
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
        public decimal? AwardBudget { get; set; }
        public decimal? AwardAlreadyPay { get; set; }
        public decimal? AwardRemaining { get; set; }
        public decimal? AmountManagementSubc { get; set; }
        public decimal? WageBudget { get; set; }
        public decimal? WageAlreadPay { get; set; }
        public decimal? WageRemaining { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string AwardsContentSummary { get; set; }
        public decimal? IncludeForeignUnitAmount { get; set; }
        public decimal? ForeignUnitAmount { get; set; }
    }
}
