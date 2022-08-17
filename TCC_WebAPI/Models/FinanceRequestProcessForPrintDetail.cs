using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessForPrintDetail
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Zsfpcode { get; set; }
        public decimal? Zsfpamount { get; set; }
        public string CustomsCode { get; set; }
        public decimal? CustomsAmount { get; set; }
        public string ReInvoiceCode { get; set; }
        public decimal? ReInvoiceAmount { get; set; }
    }
}
