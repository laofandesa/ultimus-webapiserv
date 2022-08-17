using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleSubmitLogTime
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? StepId { get; set; }
        public string StepName { get; set; }
        public string SubmitTimes { get; set; }
    }
}
