using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInvoicesRenderedRecevelist
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Requestor { get; set; }
        public string Category { get; set; }
        public string Sprocessname { get; set; }
        public int? Sincident { get; set; }
        public string Sformnumber { get; set; }
        public int? BillCategoryValue { get; set; }
        public string BillCategoryText { get; set; }
        public string BillCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillTaxAmount { get; set; }
        public decimal? Amount { get; set; }
        public string TaxRateCode { get; set; }
        public string TaxRateText { get; set; }
        public string ContanctCode { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public decimal? DeductibleAmount { get; set; }
        public decimal? ReDeductibleAmount { get; set; }
        public string ProofCode { get; set; }
    }
}
