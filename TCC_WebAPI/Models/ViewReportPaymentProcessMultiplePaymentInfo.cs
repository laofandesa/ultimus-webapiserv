using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportPaymentProcessMultiplePaymentInfo
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? PaymentNode { get; set; }
        public string PaymentNodeName { get; set; }
        public string PaymentDescription { get; set; }
        public string PaymentReceiptCode { get; set; }
        public string PaymentCommercialInvoiceCode { get; set; }
        public string PaymentAmountLowercase { get; set; }
        public string PaymentAmountUppercase { get; set; }
        public string ContractCode { get; set; }
        public string ContractCurrency { get; set; }
        public string PaymentAmountPercentage { get; set; }
        public string PaymentTotalTime { get; set; }
        public string PaymentTotalTimePercentage { get; set; }
        public string PaymentNote { get; set; }
        public decimal? PaymentPayableAmount { get; set; }
        public string PaymentPayableAmountPercentage { get; set; }
        public decimal? PaymentWithholdingAmount { get; set; }
        public string PaymentWithholdingAmountPercentage { get; set; }
        public decimal? PaymentActualPayments { get; set; }
        public string PaymentActualPaymentsPercentage { get; set; }
        public decimal? PaymentPayableTotalTime { get; set; }
        public string PaymentPayableTotalTimePercentage { get; set; }
        public string WithholdingTax { get; set; }
        public string OtherCost { get; set; }
        public string OtherPaymentAmount { get; set; }
        public string PaymentInputVat { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string Sheamount { get; set; }
        public string PaymentWithoutInputVat { get; set; }
        public string PaymentWithoutOtherTax { get; set; }
        public string FinanceWithoutInputVat { get; set; }
        public string PaymentFineAmount { get; set; }
        public string PayContractExchange { get; set; }
        public string PaymentContractAmount { get; set; }
    }
}
