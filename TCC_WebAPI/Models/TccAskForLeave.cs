using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAskForLeave
    {
        public int Id { get; set; }
        public string MainProcessName { get; set; }
        public int? MainIncident { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public string CardNo { get; set; }
        public DateTime? TravelBeginDate { get; set; }
        public DateTime? TravelEndDate { get; set; }
        public int? TotalDays { get; set; }
        public int? TotalHours { get; set; }
        public int? TotalMinutes { get; set; }
        public string HaveBorrow { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
    }
}
