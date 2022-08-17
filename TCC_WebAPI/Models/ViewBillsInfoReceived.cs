using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBillsInfoReceived
    {
        public int? InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public string BillCode { get; set; }
        public string InvoiceCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
    }
}
