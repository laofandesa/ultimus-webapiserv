using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccCyvehicleFare
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyUserKey { get; set; }
        public string ApplyMobile { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public int? ApplyYear { get; set; }
        public int? ApplyQuarter { get; set; }
        public int? ApplyType { get; set; }
        public string ApplyTimeType { get; set; }
        public DateTime? ApplyStartDate { get; set; }
        public DateTime? ApplyEndDate { get; set; }
        public string PayCompnayCode { get; set; }
        public string AcceptCompayCode { get; set; }
        public decimal? QuarterFare { get; set; }
    }
}
