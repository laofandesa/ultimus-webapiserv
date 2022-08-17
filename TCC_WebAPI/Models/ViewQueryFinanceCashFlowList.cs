using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewQueryFinanceCashFlowList
    {
        public string ProjectCode { get; set; }
        public int ReceivedYear { get; set; }
        public int ReceivedMonth { get; set; }
        public decimal? ReceiveSumTotal { get; set; }
        public double? ReceivePct { get; set; }
        public decimal? ReceiveSumByMonth { get; set; }
        public double? PaymentSumTotal { get; set; }
        public double? Ncf { get; set; }
    }
}
