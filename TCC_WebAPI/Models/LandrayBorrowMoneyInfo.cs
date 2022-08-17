using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class LandrayBorrowMoneyInfo
    {
        public string Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public int? BorrowType { get; set; }
        public string BorrowTypeText { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? BorrowMoneySmall { get; set; }
        public string CurrencyAb { get; set; }
        public decimal? MoneyYb { get; set; }
        public decimal? Rate { get; set; }
        public int? ToDomesticOversea { get; set; }
        public string ConfirmStatus { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public int? Status { get; set; }
        public string LandrayFormCode { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
