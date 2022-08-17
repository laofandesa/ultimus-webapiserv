using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportRequestProcessOfficialBill
    {
        public string ProcessName { get; set; }
        public int Id { get; set; }
        public int? Incident { get; set; }
        public string BillType { get; set; }
        public string InvoiceDate { get; set; }
        public string BillCode { get; set; }
        public string BillContent { get; set; }
        public string BillAmount { get; set; }
        public string BillTaxAmount { get; set; }
        public string TaxRate { get; set; }
        public string Amount { get; set; }
        public int? ListOfSheets { get; set; }
    }
}
