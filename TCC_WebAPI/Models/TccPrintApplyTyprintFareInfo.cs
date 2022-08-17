using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPrintApplyTyprintFareInfo
    {
        public long Id { get; set; }
        public string FormNumber { get; set; }
        public string DeptInfo { get; set; }
        public int? ApplyType { get; set; }
        public string ProjectNo { get; set; }
        public string UseDeptId { get; set; }
        public string ManagerInfo { get; set; }
        public decimal? AcceptFare { get; set; }
        public int? ApplyYear { get; set; }
        public int? ApplyQuarter { get; set; }
        public string AcceptCompayCode { get; set; }
        public DateTime? ApplyStartDate { get; set; }
        public DateTime? ApplyEndDate { get; set; }
    }
}
