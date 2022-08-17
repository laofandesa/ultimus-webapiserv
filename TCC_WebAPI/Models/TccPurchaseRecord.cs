using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPurchaseRecord
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestDeptNo { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestUserName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestTelephone { get; set; }
        public string Category { get; set; }
        public string CategoryCode { get; set; }
        public string ProductType { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductVersion { get; set; }
        public string DetailName { get; set; }
        public decimal? BudgetFareLowercase { get; set; }
        public string BudgetFareUppercase { get; set; }
        public string ProjectApply { get; set; }
        public string Manager { get; set; }
        public string ApplyReason { get; set; }
    }
}
