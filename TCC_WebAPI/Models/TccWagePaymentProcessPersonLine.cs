using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWagePaymentProcessPersonLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string RequestLoginName { get; set; }
        public string AwardCategory { get; set; }
        public string PersonLoginName { get; set; }
        public string UserIdentity { get; set; }
        public string PersonRealName { get; set; }
        public string PersonCategory { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal? FixWages { get; set; }
        public decimal? PostAllowance { get; set; }
        public string AnnualAssessment { get; set; }
        public decimal? AnnualAssessmentFactor { get; set; }
        public string PostLevelCode { get; set; }
        public string PostLevelName { get; set; }
        public string Post { get; set; }
        public decimal? PostFactor { get; set; }
        public decimal? OverTimeHours { get; set; }
        public string OverTimeReasons { get; set; }
        public string OverTimeDescription { get; set; }
        public decimal? LoadFactor { get; set; }
        public decimal? AssessmentFactor { get; set; }
        public decimal? Adjustment { get; set; }
        public decimal? AwardBase { get; set; }
        public decimal? Amount { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public string IsFanPin { get; set; }
        public string AwardAssignFlag { get; set; }
        public int ModifyFromInit { get; set; }
    }
}
