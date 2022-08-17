using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInvoicesAccount
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public string ConfirmLoginName { get; set; }
        public string ConfirmRealName { get; set; }
        public string ConfirmIdentity { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string AuditAccountLoginName { get; set; }
        public string AuditAccountRealName { get; set; }
        public string AuditAccountIdentity { get; set; }
        public DateTime? AuditAccountDate { get; set; }
        public int? Voucherid { get; set; }
        public int? Attachment { get; set; }
    }
}
