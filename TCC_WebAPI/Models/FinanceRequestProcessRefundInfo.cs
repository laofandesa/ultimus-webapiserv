using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessRefundInfo
    {
        public int Fid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestPhone { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public int? MainRequestType { get; set; }
        public int? MainRequestPayCategory { get; set; }
        public string MainProjectCode { get; set; }
        public string MainProjectName { get; set; }
        public string MainProcessName { get; set; }
        public string MainIncident { get; set; }
        public decimal? RefundAmount { get; set; }
        public string FinanceProName { get; set; }
        public string FinanceProLoginName { get; set; }
        public string AuditBusinessName { get; set; }
        public string AuditBusinessLoginName { get; set; }
        public DateTime? AuditProDate { get; set; }
        public int? ConfirmStaus { get; set; }
        public int? Voucherid { get; set; }
        public DateTime? ProcessEndDate { get; set; }
        public int? Attachment { get; set; }
        public string AccountPayCmpCode { get; set; }
        public string AccountPayCmpName { get; set; }
        public string AccountReceiveCmpCode { get; set; }
        public string AccountReceiveCmpName { get; set; }
        public string PayBankCode { get; set; }
        public string PayBankName { get; set; }
        public string PayCheque { get; set; }
    }
}
