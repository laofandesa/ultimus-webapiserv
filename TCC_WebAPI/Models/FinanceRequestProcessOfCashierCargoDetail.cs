using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessOfCashierCargoDetail
    {
        public int Id { get; set; }
        public int? FId { get; set; }
        public string ApplyFormNumber { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string Batch { get; set; }
        public string CustomsCode { get; set; }
        public string CdCode { get; set; }
        public DateTime? ExportDate { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? InvoiceAmountTotal { get; set; }
        public decimal? InvoiceTotalBillAmount { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public decimal? ExpectedTax { get; set; }
        public decimal? PaidInTax { get; set; }
        public decimal? ShouldReTax { get; set; }
        public decimal? MaterialCosts { get; set; }
        public decimal? EquipmentCosts { get; set; }
        public decimal? MaterialTax { get; set; }
        public decimal? EquipmentTax { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string ContractCodeCkts { get; set; }
        public string ContractNameCkts { get; set; }
        public string SupplierCodeCkts { get; set; }
        public string SupplierNameCkts { get; set; }
    }
}
