using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewExpensingInfo
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public int? ConfirmStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ClaimsDepartmentCode { get; set; }
        public string ClaimsDepartmentName { get; set; }
        public string RequestRealName { get; set; }
        public int? BorrowType { get; set; }
        public decimal? MoneyYb { get; set; }
        public string Currency { get; set; }
        public decimal? MoneyRmb { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
