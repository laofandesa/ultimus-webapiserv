using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportInvoicesReceived
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestDate { get; set; }
        public string FormNumber { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string RequestTelephone { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectSchedule { get; set; }
        public string ProjectCategory { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ContractCategory { get; set; }
        public string ContractAmount { get; set; }
        public string ContractPaymentAmount { get; set; }
        public string ContractPaymentPercentage { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string AggregateRecInvoiceAmount { get; set; }
        public string AggregateRecReceiptAmount { get; set; }
        public string AggregateWithholdingTax { get; set; }
        public string InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public string InvoiceTotalAmount { get; set; }
        public string FinaceTicketUserLoginName { get; set; }
        public string FinaceTicketUserRealName { get; set; }
        public string FinaceTicketUserIdentity { get; set; }
        public string FinaceTicketDate { get; set; }
        public int? FinaceInvoiceNumber { get; set; }
        public decimal? FinaceTotalAmount { get; set; }
        public decimal? FinaceTotalTaxAmount { get; set; }
        public decimal? FinaceTotalWithholdingTax { get; set; }
        public decimal? FinaceTotalRefundedTax { get; set; }
        public string ConfirmLoginName { get; set; }
        public string ConfirmRealName { get; set; }
        public string ConfirmIdentity { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string PaymentCategory { get; set; }
        public string ContractCurrency { get; set; }
        public int? IsDrawback { get; set; }
        public string TotelReturnTax { get; set; }
        public string PaymentCanReturnTaxAmount { get; set; }
        public string PaymentApplyReturnTaxAmount { get; set; }
        public decimal? PaymentExchange { get; set; }
        public decimal? PaymentChangeLocalCurrencyAmount { get; set; }
        public string PaymentCurrency { get; set; }
        public string PaymentReceivingCompanyName { get; set; }
        public string PaymentReceivingCompanyCode { get; set; }
        public string PaymentBankAccount { get; set; }
        public string PaymentReceivingCompanyAddress { get; set; }
        public string PaymentBankName { get; set; }
        public string PaymentLineNumbers { get; set; }
        public string PaymentBankAddress { get; set; }
        public string PaymentSwiftCode { get; set; }
        public string PaymentIbanCode { get; set; }
        public string PaymentAbacode { get; set; }
        public string SubjectCode { get; set; }
        public string FinancePaymentBank { get; set; }
        public string FinancePaymentBankAccount { get; set; }
        public int? VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public int? TaxVoucherId { get; set; }
        public string TaxVoucherCode { get; set; }
        public int? IsVoucher { get; set; }
        public string RelevanceInvoiceCategoryValue { get; set; }
        public string RelevanceInvoiceCategoryText { get; set; }
        public string CasierClaimUserName { get; set; }
        public string CasierClaimLoginUserName { get; set; }
        public DateTime? CasierClaimDate { get; set; }
        public string AccountingAuditUserName { get; set; }
        public string AccountingAuditLoginUserName { get; set; }
        public DateTime? AccountingAuditDate { get; set; }
        public int? Attachment { get; set; }
        public int? TaxAttachment { get; set; }
        public string UnitJnw { get; set; }
        public int? IsTs { get; set; }
        public int? GoodClass { get; set; }
        public string GoodClassName { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string InvoicesUnitName { get; set; }
        public string SignCode { get; set; }
        public string SignName { get; set; }
        public string TotalTaxAmount { get; set; }
        public string TaxAmount { get; set; }
        public string ProjectJnw { get; set; }
        public string SurplusReturnTax { get; set; }
        public string InvoiceTotalBillAmount { get; set; }
        public int? BillStatus { get; set; }
        public string TaxAmountRate { get; set; }
        public int? BillCts { get; set; }
        public string InvoicesFormNumber { get; set; }
        public string VchrnumCode { get; set; }
    }
}
