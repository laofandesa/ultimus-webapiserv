using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceForProjectBalanceAwardBak
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ProjectCode { get; set; }
        public string SubjectCode { get; set; }
        public decimal? ApproveMoney { get; set; }
    }
}
