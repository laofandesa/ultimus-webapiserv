using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportExpenseClaimDailyLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ExpenseDesc { get; set; }
        public string Money { get; set; }
        public int? Currency { get; set; }
        public decimal? Rate { get; set; }
        public string MoneyRmb { get; set; }
        public int? NotesNumber { get; set; }
        public string AccountSubject { get; set; }
        public string SubjectName { get; set; }
        public string VisitorUnitNameWithNum { get; set; }
        public int? VisitorNumber { get; set; }
        public string TheMasterWithNum { get; set; }
        public int? TheMasterNumber { get; set; }
        public int? BusinessObject { get; set; }
    }
}
