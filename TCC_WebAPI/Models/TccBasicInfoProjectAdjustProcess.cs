using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBasicInfoProjectAdjustProcess
    {
        public string ProjectCode { get; set; }
        public decimal? Progress { get; set; }
        public int IsEnabled { get; set; }
    }
}
