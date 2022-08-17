using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceAppInfo
    {
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string VoucherCode { get; set; }
        public string FormNumber { get; set; }
        public string OpName { get; set; }
        public DateTime? AppDate { get; set; }
        public string OpUserName { get; set; }
        public string StepName { get; set; }
        public string ApproveResult { get; set; }
    }
}
