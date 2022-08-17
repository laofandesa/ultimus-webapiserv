using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInvoicesRed
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string RequestTelephone { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? ProjectContractTotalAmount { get; set; }
        public decimal? ReceivedAmount { get; set; }
        public decimal? ReceivedPercentage { get; set; }
        public decimal? ProjectSchedule { get; set; }
        public string ProjectCategory { get; set; }
        public string OwnerCategory { get; set; }
        public string OwnerCode { get; set; }
        public string OwnerName { get; set; }
        public string InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public decimal? AggregateRenInvoiceAmount { get; set; }
        public decimal? AggregateRenReceiptAmount { get; set; }
        public decimal? InvoiceTotalAmount { get; set; }
        public string PayCompanyCode { get; set; }
        public string PayCompanyName { get; set; }
        public string PayCompanyTaxId { get; set; }
        public string PayCompanyAddress { get; set; }
        public string PayBankAccount { get; set; }
        public string PayBankName { get; set; }
        public string PayUnitedBankNumber { get; set; }
        public string PayCompanyPhone { get; set; }
        public string RenderedCategoryValue { get; set; }
        public string RenderedCategoryText { get; set; }
        public string BillContent { get; set; }
        public string Remark { get; set; }
        public string FinanceReceiptorRealName { get; set; }
        public int? FinanceInvoiceNumber { get; set; }
        public DateTime? FinanceTicketDate { get; set; }
        public DateTime? FinanceInvoiceDate { get; set; }
        public string FinanceBillContent { get; set; }
        public decimal? FinanceInvoiceTaxAmount { get; set; }
        public string FinanceBillBeginCode { get; set; }
        public decimal? FinanceSingleInvoiceAmount { get; set; }
        public decimal? FinanceTaxRate { get; set; }
        public string ConfirmLoginName { get; set; }
        public string ConfirmRealName { get; set; }
        public string ConfirmIdentity { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string AuditAccountLoginName { get; set; }
        public string AuditAccountRealName { get; set; }
        public string AuditAccountIdentity { get; set; }
        public DateTime? AuditAccountDate { get; set; }
        public int? Voucherid { get; set; }
        public decimal? SubMoneyOnVat { get; set; }
        public decimal? DesignOfIncome { get; set; }
        public int? Attachment { get; set; }
        public string BId { get; set; }
        public string BName { get; set; }
        public int? IsRz { get; set; }
        public string InvoicesUnitName { get; set; }
        public string SjReceiptRealName { get; set; }
        public DateTime? FinanceDateSj { get; set; }
        public int? AttachmentSj { get; set; }
        public string ProjectJnw { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? IsCs { get; set; }
        public int? AccountStatus { get; set; }
    }
}
