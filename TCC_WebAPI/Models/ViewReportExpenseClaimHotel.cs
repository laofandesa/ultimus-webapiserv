using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportExpenseClaimHotel
    {
        public int Id { get; set; }
        public string RequestLoginName { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string Category { get; set; }
        public string FromDate { get; set; }
        public string FromPlace { get; set; }
        public string ToDate { get; set; }
        public string ToPlace { get; set; }
        public string BillType { get; set; }
        public string Currency { get; set; }
        public string Rate { get; set; }
        public string Money { get; set; }
        public string MoneyRmb { get; set; }
        public int? NotesNumber { get; set; }
        public int? Days { get; set; }
        public string Beyond { get; set; }
        public string AdjustAmount { get; set; }
        public string AfterAdjustAmount { get; set; }
        public string StrokeNumber { get; set; }
        public string TicketingCompany { get; set; }
        public string BillTypeName { get; set; }
        public string CurrencyName { get; set; }
        public string TicketingCompanyName { get; set; }
    }
}
