using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportReceivedBillsInfo
    {
        public int Id { get; set; }
        public string Requestor { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string InvoiceDate { get; set; }
        public string BillCode { get; set; }
        public string BillContent { get; set; }
        public string BillAmount { get; set; }
        public string BillTaxAmount { get; set; }
        public string TaxRateCode { get; set; }
        public string TaxRateText { get; set; }
        public decimal? TaxRate { get; set; }
        public string Amount { get; set; }
        public int? Inventory { get; set; }
    }
}
