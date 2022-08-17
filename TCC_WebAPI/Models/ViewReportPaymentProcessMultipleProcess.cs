using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportPaymentProcessMultipleProcess
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestFormNumber { get; set; }
        public string RequestPayCategoryName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string PaymentReceivingCompanyName { get; set; }
        public string PaymentMethodName { get; set; }
        public string FinancePaymentAmountFmt { get; set; }
        public string PaymentAmountFmt { get; set; }
        public string FinancePaymentTotalFmt { get; set; }
        public decimal? PaymentDraftAmount { get; set; }
        public string PaymentDraftAmountFmt { get; set; }
    }
}
