using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBorrowMoneyHistory
    {
        public string RequstLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public int? BorrowType { get; set; }
        public string BorrowTypeText { get; set; }
        public string BorrowPurpose { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string PaymentType { get; set; }
        public decimal? MoneyYb { get; set; }
        public int? Currency { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public decimal? BorrowMoneySmall { get; set; }
        public DateTime? RequestDate { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
    }
}
