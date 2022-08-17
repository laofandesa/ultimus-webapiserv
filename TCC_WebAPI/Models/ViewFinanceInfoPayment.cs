using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceInfoPayment
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string VoucherCode { get; set; }
        public string RequestRealName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormType { get; set; }
        public string Currency { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string CasierClaimLoginUserName { get; set; }
        public string CasierClaimUserName { get; set; }
        public string AccountingAuditLoginUserName { get; set; }
        public string AccountingAuditUserName { get; set; }
        public string ProDept { get; set; }
        public string CustomerProvider { get; set; }
        public string OperateUserName { get; set; }
        public string PayStatusName { get; set; }
        public string Vchrnum { get; set; }
        public DateTime? AppDate01 { get; set; }
        public string StepName01 { get; set; }
        public string ApproveResult01 { get; set; }
        public DateTime? AppDate02 { get; set; }
        public string StepName02 { get; set; }
        public string ApproveResult02 { get; set; }
    }
}
