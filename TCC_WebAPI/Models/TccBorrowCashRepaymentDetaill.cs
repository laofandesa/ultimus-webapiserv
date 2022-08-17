using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBorrowCashRepaymentDetaill
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? Pid { get; set; }
        public string BorrowPersonName { get; set; }
        public string BorrowPersonUserid { get; set; }
        public int? BorrowType { get; set; }
        public int? BorrowPurpose { get; set; }
        public string BorrowCurrency { get; set; }
        public decimal? BorrowAmountYb { get; set; }
        public decimal? BorrowAmountRmb { get; set; }
        public string RepayCurrency { get; set; }
        public string RepayCurrencyText { get; set; }
        public decimal? RepayAmount { get; set; }
        public decimal? RepayRate { get; set; }
        public decimal? RepayAmountRmb { get; set; }
        public int? RepayType { get; set; }
        public string RepayTypeText { get; set; }
        public decimal? OffsetAmount { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
    }
}
