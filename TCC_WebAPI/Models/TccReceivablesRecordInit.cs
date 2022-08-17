using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccReceivablesRecordInit
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ContractDate { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestTypeText { get; set; }
        public string RequestNodeText { get; set; }
        public string ContanctCurrency { get; set; }
        public decimal? RequestAmount { get; set; }
        public decimal? WithholdingAmount { get; set; }
        public decimal? BuckleWaElecAmount { get; set; }
        public decimal? OwnerForfeit { get; set; }
        public decimal? ProjectPayment { get; set; }
        public decimal? ValueAddedTax { get; set; }
        public decimal? WithholdingOfVat { get; set; }
        public decimal? TaxWithholding { get; set; }
        public decimal? PayInfoAmount { get; set; }
        public string Currency { get; set; }
        public decimal? CounterFee { get; set; }
        public decimal? ReceiveAmount { get; set; }
        public decimal? ReceiveAmountRmb { get; set; }
        public decimal? ShouldReceiveAmount { get; set; }
        public decimal? ShouldReceiveAmountRmb { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Vourcherchrnum { get; set; }
    }
}
