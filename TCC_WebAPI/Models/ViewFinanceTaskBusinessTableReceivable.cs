using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceTaskBusinessTableReceivable
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public DateTime? PlanInAcctDate { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public decimal? BillAmount { get; set; }
        public string PayCmpName { get; set; }
        public string PayCmpBankAcct { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string AccountReceiveCmpName { get; set; }
        public string AccountReceiveCmpCode { get; set; }
        public string BillNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public int? FinanceStatus { get; set; }
        public decimal? Taxwithholding { get; set; }
        public string OffSingleNumber { get; set; }
    }
}
