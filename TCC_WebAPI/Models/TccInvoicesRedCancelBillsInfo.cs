using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInvoicesRedCancelBillsInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? BId { get; set; }
        public string BillCategoryText { get; set; }
        public int? BillCategoryValue { get; set; }
        public string FormNumber { get; set; }
        public string BillCode { get; set; }
        public string BillContent { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillTaxAmount { get; set; }
        public string TaxRate { get; set; }
        public decimal? Amount { get; set; }
        public int? AccountStatus { get; set; }
    }
}
