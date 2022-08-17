using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPaymentHistoryDepartmentContractNotVoucherInfoInbox
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestRealName { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestFormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string RequestPayCategoryName { get; set; }
        public string PaymentReceivingCompanyCode { get; set; }
        public string PaymentReceivingCompanyName { get; set; }
        public int? PaymentApplicationCode { get; set; }
        public string PaymentApplicationName { get; set; }
        public string PaymentDescription { get; set; }
        public decimal? FinancePaymentTotal { get; set; }
        public string FinanceCurrency { get; set; }
        public decimal? FinanceExchange { get; set; }
        public decimal? FinanceChangeLocalCurrencyAmount { get; set; }
        public string PaymentVoucherDeptCode { get; set; }
        public string PaymentVoucherDeptName { get; set; }
        public string SignSupplierCode { get; set; }
        public string SignSupplierName { get; set; }
        public string ContractCode { get; set; }
        public string InvoicesUnitName { get; set; }
        public int? ProcessStatus { get; set; }
    }
}
