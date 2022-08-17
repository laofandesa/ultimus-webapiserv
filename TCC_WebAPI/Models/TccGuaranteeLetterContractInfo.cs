using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccGuaranteeLetterContractInfo
    {
        public string ContractId { get; set; }
        public string HdId { get; set; }
        public string ContractCode { get; set; }
        public string ContractType { get; set; }
        public decimal ContractAmt { get; set; }
        public string OppositeType { get; set; }
        public string OppositeName { get; set; }
        public string MoneySrc { get; set; }
        public DateTime? ContractCreateDate { get; set; }
        public string OppositeCode { get; set; }
        public string ContractName { get; set; }
        public string AppointGrtLetter { get; set; }
        public string ContractCurrency { get; set; }
    }
}
