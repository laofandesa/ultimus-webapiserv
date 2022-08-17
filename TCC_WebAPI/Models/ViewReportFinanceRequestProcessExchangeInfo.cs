using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportFinanceRequestProcessExchangeInfo
    {
        public string Id { get; set; }
        public string Zsfpcode { get; set; }
        public decimal? Zsfpamount { get; set; }
        public string CustomsCode { get; set; }
        public decimal? CustomsAmount { get; set; }
        public string ReInvoiceCode { get; set; }
        public decimal? ReInvoiceAmount { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
    }
}
