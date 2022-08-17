using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigApprovedExtend
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? ApproveResultCode { get; set; }
        public string ApproveRemark { get; set; }
    }
}
