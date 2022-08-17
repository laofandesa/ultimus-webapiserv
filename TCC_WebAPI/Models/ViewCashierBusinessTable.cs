using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewCashierBusinessTable
    {
        public string IDeptName { get; set; }
        public string IDeptCode { get; set; }
        public string ITypeName { get; set; }
        public int? ITypeCode { get; set; }
        public string ProCode { get; set; }
        public string ProName { get; set; }
        public DateTime? Requestdate { get; set; }
        public int? PMethodCode { get; set; }
        public string PMethodName { get; set; }
        public string Currency { get; set; }
        public decimal? Amount { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormCode { get; set; }
        public string CasierClaim { get; set; }
        public int? VoucherId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public string AuditName { get; set; }
        public string BankCode { get; set; }
        public DateTime? PlanInAcctDate { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public string BillNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public int? FinanceStatus { get; set; }
        public int? Insideandoutside { get; set; }
        public string AccountReceiveCmpName { get; set; }
        public string Rate { get; set; }
        public string Billtype { get; set; }
        public string Tobilltype { get; set; }
        public string Billcontent { get; set; }
    }
}
