using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceForProjectBalanceAward
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? PayCategory { get; set; }
        public string PayCategoryName { get; set; }
        public int? PaymentNode { get; set; }
        public string PaymentNodeName { get; set; }
        public decimal? PaymentAmount { get; set; }
    }
}
