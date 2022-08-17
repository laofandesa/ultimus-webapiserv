using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccApplyWorkVisa
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestUserName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelPhone { get; set; }
        public string Country { get; set; }
        public string RemarkInfo { get; set; }
        public int? ProNum { get; set; }
    }
}
