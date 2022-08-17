using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbortLeave
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public string AbortProcessName { get; set; }
        public int? AbortIncident { get; set; }
        public string AbortFormNumber { get; set; }
        public int? ToDomesticOversea { get; set; }
        public string ToCountry { get; set; }
        public string ToCity { get; set; }
        public int? TravelType { get; set; }
        public string TravelType1 { get; set; }
        public string TaskTarget { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string InviteUnit { get; set; }
        public DateTime? AskForLeaveBeginDate { get; set; }
        public DateTime? AskForLeaveEndDate { get; set; }
        public int? TotalDays { get; set; }
        public DateTime? ActualBeginDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int? ActualTotalDays { get; set; }
        public string Remark { get; set; }
        public string FromCity { get; set; }
        public int? CompToalDays { get; set; }
        public DateTime? CompBeginDate { get; set; }
        public DateTime? CompEndDate { get; set; }
        public int? CmopDays { get; set; }
        public string IsAbort { get; set; }
        public string IsRotateRest { get; set; }
        public DateTime? ExtendDate { get; set; }
        public int? Payee { get; set; }
    }
}
