using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultiplePaymentInfo
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public int? PaymentNode { get; set; }
        public string PaymentNodeName { get; set; }
        public string PaymentDescription { get; set; }
        public string PaymentReceiptCode { get; set; }
        public string PaymentCommercialInvoiceCode { get; set; }
        public decimal? PaymentAmountLowercase { get; set; }
        public string PaymentAmountUppercase { get; set; }
        public string ContractCode { get; set; }
        public decimal? PaymentAmountPercentage { get; set; }
        public decimal? PaymentTotalTime { get; set; }
        public decimal? PaymentTotalTimePercentage { get; set; }
        public string PaymentNote { get; set; }
        public decimal? PaymentPayableAmount { get; set; }
        public decimal? PaymentPayableAmountPercentage { get; set; }
        public decimal? PaymentWithholdingAmount { get; set; }
        public decimal? PaymentWithholdingAmountPercentage { get; set; }
        public decimal? PaymentActualPayments { get; set; }
        public decimal? PaymentActualPaymentsPercentage { get; set; }
        public decimal? PaymentPayableTotalTime { get; set; }
        public decimal? PaymentPayableTotalTimePercentage { get; set; }
        public decimal? WithholdingTax { get; set; }
        public decimal? OtherCost { get; set; }
        public decimal? OtherPaymentAmount { get; set; }
        public decimal? PaymentInputVat { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? Sheamount { get; set; }
        public decimal? PaymentWithoutInputVat { get; set; }
        public decimal? PaymentWithoutOtherTax { get; set; }
        public decimal? FinanceWithoutInputVat { get; set; }
        public decimal? PaymentFineAmount { get; set; }
        public decimal? PayContractExchange { get; set; }
        public decimal? PaymentContractAmount { get; set; }
        public decimal? PaymentOtherBuyAmount { get; set; }
        public int? CalculateMode { get; set; }
        public int? DecimalDigit { get; set; }
        public string MainContractCurrency { get; set; }
        public decimal? OtherBuyExchange { get; set; }
        public decimal? OtherBuyRmb { get; set; }
    }
}
