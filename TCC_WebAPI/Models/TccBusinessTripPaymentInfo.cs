using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBusinessTripPaymentInfo
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Requestor { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string BillCode { get; set; }
        public string BillContent { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillTaxAmount { get; set; }
        public string TaxRateCode { get; set; }
        public string TaxRateText { get; set; }
        public decimal? Amount { get; set; }
        public int? Inventory { get; set; }
    }
}
