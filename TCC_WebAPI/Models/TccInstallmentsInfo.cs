using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInstallmentsInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string BillCode { get; set; }
        public string InvoiceCode { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillTaxAmount { get; set; }
        public decimal? Amount { get; set; }
        public string TaxRateCode { get; set; }
        public string TaxRateText { get; set; }
        public string RprocessName { get; set; }
        public int? Rincident { get; set; }
        public string RformNumber { get; set; }
        public string RbillCode { get; set; }
        public string RinvoiceCode { get; set; }
        public DateTime? RinvoiceDate { get; set; }
        public string RprojectCode { get; set; }
        public string RprojectName { get; set; }
        public string Ramount { get; set; }
        public string Policy { get; set; }
        public string PolicyProject { get; set; }
        public decimal? DifferenceAmount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? PrepaidTaxesAmount { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
