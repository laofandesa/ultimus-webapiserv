using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessBillsNoProject
    {
        public int Id { get; set; }
        public string Requestor { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string BillType { get; set; }
        public int? BillTypeValue { get; set; }
        public string BillCode { get; set; }
        public string BillContent { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillTaxAmount { get; set; }
        public string TaxRateCode { get; set; }
        public string TaxRateText { get; set; }
        public decimal? Amount { get; set; }
        public int? Inventory { get; set; }
        public string RId { get; set; }
        public string RCreateTime { get; set; }
        public string RTitle { get; set; }
        public string RName { get; set; }
        public string ByAttachment { get; set; }
    }
}
