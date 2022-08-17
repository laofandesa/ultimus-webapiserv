using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigMessageSummaryStep
    {
        public int MssId { get; set; }
        public string MssProcessName { get; set; }
        public string MssStepName { get; set; }
        public int? MssRealTimeRemind { get; set; }
    }
}
