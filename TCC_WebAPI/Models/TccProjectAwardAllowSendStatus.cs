using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectAwardAllowSendStatus
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public int? AllowSendStatus { get; set; }
        public string Operator { get; set; }
        public string Creattime { get; set; }
    }
}
