using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectAwardSendPlanApply
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyUserName { get; set; }
        public string ApplyUserLoginName { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDeptCode { get; set; }
        public string FormSerialNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string ProjectAwardName { get; set; }
        public string ProjectAwardCode { get; set; }
        public decimal? ProjectAwardAmount { get; set; }
        public decimal? RatifyAwardAmount { get; set; }
        public decimal? OldprocessSendAmount { get; set; }
    }
}
