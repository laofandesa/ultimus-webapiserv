using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportRequestProcessFormalBill
    {
        public string ProcessName { get; set; }
        public int Id { get; set; }
        public int? Incident { get; set; }
        public string BillType { get; set; }
        public string InvoiceDate { get; set; }
        public string BillCode { get; set; }
        public string BillContent { get; set; }
        public string BillAmount { get; set; }
    }
}
