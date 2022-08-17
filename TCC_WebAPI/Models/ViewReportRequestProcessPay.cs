using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportRequestProcessPay
    {
        public string Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ContractCode { get; set; }
        public string AccountReCmpName { get; set; }
        public string PayInfoType { get; set; }
        public string PaymentNodeName { get; set; }
        public string PaymentDescription { get; set; }
        public string ContractCurrency { get; set; }
        public string PaymentAmountLowercase { get; set; }
        public string PaymentAmountUppercase { get; set; }
        public string PaymentAmountOfHse { get; set; }
        public string WaElecAmount { get; set; }
        public string PaymentAmountPercentage { get; set; }
        public decimal? PaymentTotalTime { get; set; }
        public string PaymentTotalTimePercentage { get; set; }
        public string ReceiptNumber { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
