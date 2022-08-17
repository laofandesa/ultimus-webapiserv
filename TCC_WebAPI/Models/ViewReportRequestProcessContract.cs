using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportRequestProcessContract
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Mode { get; set; }
        public string Currency { get; set; }
        public string SignAmount { get; set; }
        public string ModifiedAmount { get; set; }
        public string TotalAmount { get; set; }
        public decimal? ContractRate { get; set; }
        public string RmbeqAmount { get; set; }
        public string UsdeqAmount { get; set; }
        public string AddupReceivedAmount { get; set; }
        public string AddupReceivedPct { get; set; }
        public string AccountPayCmpName { get; set; }
        public string AccountReceiveCmpName { get; set; }
    }
}
