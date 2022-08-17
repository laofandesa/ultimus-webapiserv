using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewOuterUnitInfo
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string FormNumber { get; set; }
        public string Summary { get; set; }
        public decimal? Amount { get; set; }
        public string AwardCode { get; set; }
        public string AwardName { get; set; }
        public DateTime? RequestDate { get; set; }
        public decimal? ForeignUnitAmount { get; set; }
        public string Status { get; set; }
    }
}
