using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWagePaymentProcessDeptLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string RequestLoginName { get; set; }
        public string AwardCategory { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string DeptManagerLoginName { get; set; }
        public string DeptManagerIdentity { get; set; }
        public string DeptManagerRealName { get; set; }
        public int? PersonCount { get; set; }
        public decimal? AnnualAssessmentFactor { get; set; }
        public decimal? PostFactor { get; set; }
        public decimal? LoadFactor { get; set; }
        public decimal? CurrentQcompletedWork { get; set; }
        public decimal? Adjustment { get; set; }
        public decimal? AwardBase { get; set; }
        public decimal? Amount { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public int? AssignStatus { get; set; }
        public DateTime? AssignDate { get; set; }
    }
}
