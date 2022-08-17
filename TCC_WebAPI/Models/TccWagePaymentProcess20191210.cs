using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWagePaymentProcess20191210
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? Status { get; set; }
        public string FormNumber { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string IdentityId { get; set; }
        public string ApplyUserLoginName { get; set; }
        public string ApplyUserName { get; set; }
        public string ApplyDeptName { get; set; }
        public string ApplyDeptCode { get; set; }
        public int? PaymentType { get; set; }
        public string AssignUserLoginName { get; set; }
        public string AssignUserRealName { get; set; }
        public string AssignUserIdentity { get; set; }
        public string AwardCategory { get; set; }
        public decimal? AwardBudget { get; set; }
        public decimal? AwardAlreadyPay { get; set; }
        public decimal? AwardRemaining { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string ApplyCategory { get; set; }
        public string AwardsContentSummary { get; set; }
        public string WealCode { get; set; }
        public string WealName { get; set; }
        public string WealSummary { get; set; }
        public decimal? IncludeOvertime { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
    }
}
