using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWagePaymentProcessDeptAssign
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string AwardCategory { get; set; }
        public string AssignFromDept { get; set; }
        public string AssignFromDeptName { get; set; }
        public string AssignFromUser { get; set; }
        public string AssignFromUserIdentity { get; set; }
        public string AssignFromUserRealName { get; set; }
        public string PersonLoginName { get; set; }
        public string UserIdentity { get; set; }
        public string PersonRealName { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal? AnnualAssessmentFactor { get; set; }
        public decimal? PostFactor { get; set; }
        public decimal? LoadFactor { get; set; }
        public decimal? Adjustment { get; set; }
        public decimal? AwardBase { get; set; }
        public decimal? Amount { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public string IsFanPin { get; set; }
    }
}
