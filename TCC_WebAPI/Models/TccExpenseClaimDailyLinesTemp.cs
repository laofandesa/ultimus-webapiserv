using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimDailyLinesTemp
    {
        public int Id { get; set; }
        public string RequestLoginName { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ExpenseDesc { get; set; }
        public decimal? Money { get; set; }
        public int? Currency { get; set; }
        public decimal? Rate { get; set; }
        public decimal? MoneyRmb { get; set; }
        public int? NotesNumber { get; set; }
        public string AccountSubject { get; set; }
        public string SubjectName { get; set; }
        public string VisitorUnitNameWithNum { get; set; }
        public int? VisitorNumber { get; set; }
        public string TheMasterWithNum { get; set; }
        public int? TheMasterNumber { get; set; }
        public int? BusinessObject { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillTaxAmount { get; set; }
        public string TaxRate { get; set; }
        public string TaxRateName { get; set; }
        public int? InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public string BillCode { get; set; }
        public string InvoiceCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? Zdlevel { get; set; }
        public string IsLeader { get; set; }
        public int? BanquetP { get; set; }
        public string IsCliquor { get; set; }
        public string TheMasterWithNumId { get; set; }
        public int? Zdstander { get; set; }
        public string RId { get; set; }
        public string RCreateTime { get; set; }
        public string RTitle { get; set; }
        public string RName { get; set; }
        public string ByAttachment { get; set; }
        public int? IsLianhao { get; set; }
    }
}
