using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInvoicesReceivedPaymentList
    {
        public int Id { get; set; }
        public int? Rid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLogin { get; set; }
        public string PaymentProcessName { get; set; }
        public int? PaymentIncident { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestRealName { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestFormNumber { get; set; }
        public string PaymentReceivingCompanyCode { get; set; }
        public string PaymentReceivingCompanyName { get; set; }
        public decimal? FinancePaymentTotal { get; set; }
        public int? Pid { get; set; }
        public string ApplicationName { get; set; }
        public int? ApplicationCode { get; set; }
        public string VoucherDeptCode { get; set; }
        public string VoucherDeptName { get; set; }
        public string FinanceCurrency { get; set; }
        public decimal? FinanceExchange { get; set; }
        public decimal? FinanceRmb { get; set; }
    }
}
