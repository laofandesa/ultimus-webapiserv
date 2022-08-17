using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultiplePeptjInfo
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Xmjl { get; set; }
        public decimal? Total { get; set; }
        public string UnitCode { get; set; }
        public string UnitSid { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string Sid { get; set; }
        public string FormNumber { get; set; }
    }
}
