using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReceivablesInbox
    {
        public int FId { get; set; }
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManagerName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestLoginName { get; set; }
        public string FormNumber { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string ProjectCategory { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public decimal? BillAmount { get; set; }
        public string PaidAmount { get; set; }
        public string BankNoticeNo { get; set; }
        public decimal ReceivingAmount { get; set; }
        public string FFormNumber { get; set; }
        public string AccountReceiveCmpCode { get; set; }
        public string AccountReceiveCmpName { get; set; }
    }
}
