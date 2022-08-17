using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportPaymentProcessMultipleBillInfo
    {
        public string InvoiceDate { get; set; }
        public string BillCode { get; set; }
        public string BillContent { get; set; }
        public string Currency { get; set; }
        public string BillAmount { get; set; }
        public string BillAmountRmb { get; set; }
        public string Exchange { get; set; }
        public string BillTaxAmount { get; set; }
        public string BillTaxAmountRmb { get; set; }
        public string Amount { get; set; }
        public string AmountRmb { get; set; }
        public string TaxRateText { get; set; }
        public int? CalculateMode { get; set; }
        public int? Inventory { get; set; }
        public int? Pid { get; set; }
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
    }
}
