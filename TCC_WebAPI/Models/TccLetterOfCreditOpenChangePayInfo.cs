using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccLetterOfCreditOpenChangePayInfo
    {
        public int Id { get; set; }
        public int? Incident { get; set; }
        public string ProcessName { get; set; }
        public string RequestFormNumber { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ApPaymentNode { get; set; }
        public string ApPaymentNodeName { get; set; }
        public DateTime? ApPaymentTime { get; set; }
        public decimal? ApPaymentAmount { get; set; }
        public string ApPaymentCurrency { get; set; }
        public decimal? ApPaymentTax { get; set; }
        public decimal? ApPaymentRmb { get; set; }
        public int? ApStatus { get; set; }
        public int? Isnewest { get; set; }
        public DateTime? ApPaymentTimeChange { get; set; }
    }
}
