using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReceivedByPayMentInfo
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ProjectCode { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestRealName { get; set; }
        public string ApproverName { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Rmbamount { get; set; }
        public string Currency { get; set; }
        public string PaymentMethodName { get; set; }
        public int PaymentMethod { get; set; }
        public int ExpenseCode { get; set; }
        public string ExpenseName { get; set; }
        public DateTime? Acccountdate { get; set; }
        public string ReceiveUnitName { get; set; }
        public string OperaterName { get; set; }
    }
}
