using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimTravelLine
    {
        public int Id { get; set; }
        public string RequestLoginName { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string Category { get; set; }
        public DateTime? FromDate { get; set; }
        public string FromPlace { get; set; }
        public DateTime? ToDate { get; set; }
        public string ToPlace { get; set; }
        public string BillType { get; set; }
        public string Currency { get; set; }
        public string Rate { get; set; }
        public decimal? Money { get; set; }
        public decimal? MoneyRmb { get; set; }
        public int? NotesNumber { get; set; }
        public int? Days { get; set; }
        public string Beyond { get; set; }
        public decimal? AdjustAmount { get; set; }
        public decimal? AfterAdjustAmount { get; set; }
        public string StrokeNumber { get; set; }
        public string TicketingCompany { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillTaxAmount { get; set; }
        public string TaxRate { get; set; }
        public string TaxRateName { get; set; }
        public int? InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public string BillCode { get; set; }
        public string InvoiceCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string TravellingPeople { get; set; }
        public int? TravellingTypeCode { get; set; }
        public string TravellingTypeName { get; set; }
        public string TravellingCompany { get; set; }
        public string TravellingNumber { get; set; }
        public string TravelingCode { get; set; }
        public decimal? TravellingMoney { get; set; }
        public string TravellingGrade { get; set; }
        public decimal? TravellingSurcharge { get; set; }
        public string TravellingIsTaxPayable { get; set; }
        public string IsCollected { get; set; }
        public string RId { get; set; }
        public string RCreateTime { get; set; }
        public string RTitle { get; set; }
        public string RName { get; set; }
        public string ByAttachment { get; set; }
    }
}
