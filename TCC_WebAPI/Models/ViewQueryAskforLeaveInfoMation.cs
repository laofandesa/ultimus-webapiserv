using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewQueryAskforLeaveInfoMation
    {
        public int ApplyType { get; set; }
        public string MainProcessName { get; set; }
        public int? MainIncident { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string UserLoginName { get; set; }
        public string DeptId { get; set; }
        public string UserRealName { get; set; }
        public string UserIdentity { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? TotalDays { get; set; }
        public int? TravelTypeValue { get; set; }
        public string TravelTypeText { get; set; }
        public string FromCity { get; set; }
        public string ToDomesticOversea { get; set; }
        public string ProjectCode { get; set; }
        public string ToCountry { get; set; }
        public string ToCity { get; set; }
        public string TaskTarget { get; set; }
        public int Flag { get; set; }
    }
}
