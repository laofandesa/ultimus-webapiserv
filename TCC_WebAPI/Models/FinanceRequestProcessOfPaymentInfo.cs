using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessOfPaymentInfo
    {
        public string Id { get; set; }
        public string ProcessId { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ContractType { get; set; }
        public string ContractCategory { get; set; }
        public string CrCurcency { get; set; }
        public string SignAmount { get; set; }
        public string ModifiedAmount { get; set; }
        public string TotalAmount { get; set; }
        public decimal? CrPaymentAmount { get; set; }
        public decimal? CrPaymentAmountPer { get; set; }
        public decimal? CrAlPaymentAmount { get; set; }
        public decimal? CrAlPaymentAmountPer { get; set; }
        public int? PaymentNode { get; set; }
        public string PaymentNodeName { get; set; }
        public string PaymentDescription { get; set; }
        public string ContractCurrency { get; set; }
        public decimal? PaymentAmountLowercase { get; set; }
        public string PaymentAmountUppercase { get; set; }
        public decimal? PaymentAmountPercentage { get; set; }
        public decimal? PaymentTotalTime { get; set; }
        public decimal? PaymentTotalTimePercentage { get; set; }
        public string ReCmpCode { get; set; }
        public string ReCmpName { get; set; }
        public string AccountReCmpCode { get; set; }
        public string AccountReCmpName { get; set; }
        public string Inandoutside { get; set; }
        public string PayInfoType { get; set; }
        public string ReceiptNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string PaymentNote { get; set; }
        public decimal? PaymentAmountOfHse { get; set; }
        public decimal? WaElecAmount { get; set; }
    }
}
