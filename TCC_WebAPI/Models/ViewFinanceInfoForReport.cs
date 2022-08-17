using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceInfoForReport
    {
        public long? Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string VoucherCode { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormType { get; set; }
        public string Currency { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? ExchangeToRmb { get; set; }
        public string CasierClaimLoginUserName { get; set; }
        public string CasierClaimUserName { get; set; }
        public string AccountingAuditLoginUserName { get; set; }
        public string AccountingAuditUserName { get; set; }
        public string ForDeptName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ForCustomer { get; set; }
        public int? ConfirmStatus { get; set; }
        public int? ProcessStatus { get; set; }
    }
}
