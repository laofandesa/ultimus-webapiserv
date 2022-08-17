using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewMonthlyPaymentPaidDetail
    {
        public decimal? FinanceChangeLocalCurrencyAmount { get; set; }
        public string ProjectCode { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? PaymentNode { get; set; }
        public string PaymentNodeName { get; set; }
        public int? RequestPayCategory { get; set; }
        public string RequestPayCategoryName { get; set; }
        public string CreateDate { get; set; }
        public int? Flag { get; set; }
    }
}
