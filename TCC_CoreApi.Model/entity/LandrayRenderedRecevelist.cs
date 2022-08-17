using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_CoreApi.Model.entity
{
    public partial class LandrayRenderedRecevelist
    {
        public int Id { get; set; }
        public string fd_id { get; set; }
        public string LyID { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ApplyRateCode { get; set; }
        public string ApplyRateText { get; set; }
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
        public decimal? DiffAdvanceTax { get; set; }
        public decimal? TaxDues { get; set; }
        public decimal? AmountDeducted { get; set; }
        public string ProofCode { get; set; }
        public int? Flag { get; set; }
    }
}
