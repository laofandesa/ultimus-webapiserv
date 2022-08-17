using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessRquest
    {
        public string Id { get; set; }
        public string ProcessId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string RequestNode { get; set; }
        public string RequestDesc { get; set; }
        public string RequestMethod { get; set; }
        public decimal? CurRequestAmount { get; set; }
        public string CurRequestAmountUpp { get; set; }
        public string CurCurrency { get; set; }
        public decimal? CurAddupReceivedPct { get; set; }
        public decimal? CurAddupReceivedAmount { get; set; }
        public string CodeName { get; set; }
        public string ContanctCode { get; set; }
        public decimal? WithholdingAmount { get; set; }
        public decimal? Taxwithholding { get; set; }
        public decimal? ProjectPayment { get; set; }
        public decimal? ValueAddedTax { get; set; }
        public decimal? WithholdingOfVat { get; set; }
        public decimal? BuckleWaElecAmount { get; set; }
        public decimal? OwnerForfeit { get; set; }
    }
}
