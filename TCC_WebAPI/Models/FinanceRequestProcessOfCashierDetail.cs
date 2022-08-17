using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessOfCashierDetail
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public decimal? ReceBillAmount { get; set; }
        public decimal? ReceTaxAmount { get; set; }
        public decimal? ReceAmount { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string ProcessDigst { get; set; }
        public int? AmountCategory { get; set; }
        public string AmountCategoryName { get; set; }
        public string TaxRate { get; set; }
        public string TaxRateName { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public string BillCode { get; set; }
        public int? NotesNumber { get; set; }
        public string IsTaxVoucher { get; set; }
        public string RId { get; set; }
        public string RCreateTime { get; set; }
        public string RTitle { get; set; }
        public string RName { get; set; }
        public string ByAttachment { get; set; }
    }
}
