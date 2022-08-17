using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPeptj82ProjectProcessTemp
    {
        public long? Sid { get; set; }
        public long? ProjSid { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string Iyear { get; set; }
        public string Imonth { get; set; }
        public double? CheckValue { get; set; }
    }
}
