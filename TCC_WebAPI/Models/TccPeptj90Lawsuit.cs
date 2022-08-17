using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPeptj90Lawsuit
    {
        public long Sid { get; set; }
        public long? SupSid { get; set; }
        public string SupCode { get; set; }
        public string SupName { get; set; }
        public int? RemarkFirst { get; set; }
        public int? RemarkSecond { get; set; }
    }
}
