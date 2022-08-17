using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHasHappenedBorrowMoneyInfo
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequstLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public int? BorrowType { get; set; }
        public string BorrowTypeText { get; set; }
        public int? BorrowPurpose { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? BorrowMoneySmall { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public decimal? MoneyYb { get; set; }
        public decimal? Rate { get; set; }
        public int? ToDomesticOversea { get; set; }
        public int? ConfirmStatus { get; set; }
        public DateTime? ConfirmDate { get; set; }
    }
}
