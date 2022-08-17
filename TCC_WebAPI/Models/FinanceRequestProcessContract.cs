using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessContract
    {
        public string Id { get; set; }
        public string ProcessId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Mode { get; set; }
        public string Currency { get; set; }
        public decimal SignAmount { get; set; }
        public decimal ModifiedAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal RmbeqAmount { get; set; }
        public decimal AddupReceivedPct { get; set; }
        public decimal AddupReceivedAmount { get; set; }
        public string RequestNode { get; set; }
        public string RequestDesc { get; set; }
        public string RequestMethod { get; set; }
        public decimal CurRequestAmount { get; set; }
        public string CurRequestAmountUpp { get; set; }
        public string CurCurrency { get; set; }
        public decimal CurAddupReceivedPct { get; set; }
        public decimal CurAddupReceivedAmount { get; set; }
        public decimal? ContractRate { get; set; }
        public decimal? UsdeqAmount { get; set; }
        public string MultiCurrency { get; set; }
        public string AccountPayCmpCode { get; set; }
        public string AccountPayCmpName { get; set; }
        public string AccountReceiveCmpCode { get; set; }
        public string AccountReceiveCmpName { get; set; }
    }
}
