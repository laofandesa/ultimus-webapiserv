using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewContractPaymentInfo1
    {
        public string ProjectCode { get; set; }
        public string ContractCode { get; set; }
        public string ContanctCategory { get; set; }
        public double? ContractAmountOc { get; set; }
        public decimal PaymentAmountOc { get; set; }
        public double? PperOc { get; set; }
        public string Bz { get; set; }
        public double? ContractAmountCny { get; set; }
        public decimal PaymentAmountCny { get; set; }
        public double? PperCny { get; set; }
    }
}
