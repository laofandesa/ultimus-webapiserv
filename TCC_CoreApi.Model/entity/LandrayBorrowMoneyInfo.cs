using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_CoreApi.Model.entity
{
    public partial class LandrayBorrowMoneyInfo
    {
        public int Id { get; set; }
        public string fd_id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string Request_LoginName { get; set; }
        public string Request_RealName { get; set; }
        public string Request_UserIdentity { get; set; }
        public string Request_DeptCode { get; set; }
        public string Request_DeptName { get; set; }
        public DateTime? Request_Date { get; set; }
        public int? BorrowType { get; set; }
        public string BorrowTypeText { get; set; }
        public int? BorrowPurpose { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? BorrowMoney_Small { get; set; }
        public string CurrencyAb { get; set; }
        public decimal? Money_Yb { get; set; }
        public decimal? Rate { get; set; }
        public int? ToDomesticOversea { get; set; }
        public string ConfirmStatus { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public int? Flag { get; set; }
        public string LandrayFormCode { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
