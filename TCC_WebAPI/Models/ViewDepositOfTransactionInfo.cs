using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewDepositOfTransactionInfo
    {
        public int Flag { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string RequestRealName { get; set; }
        public decimal? ReceiveAmount { get; set; }
        public string Currency { get; set; }
        public decimal? ChangeLocalCurrencyAmount { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
