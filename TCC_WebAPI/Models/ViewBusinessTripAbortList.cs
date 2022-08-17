using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBusinessTripAbortList
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestRealName { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? TravelBeginDate { get; set; }
        public DateTime? TravelEndDate { get; set; }
        public int? TotalDays { get; set; }
        public int? TravelType { get; set; }
        public string TravelTypeName { get; set; }
        public int? ToDomesticOversea { get; set; }
        public string ToCountry { get; set; }
        public string ToCity { get; set; }
        public string TaskTarget { get; set; }
        public string FormNumber { get; set; }
    }
}
