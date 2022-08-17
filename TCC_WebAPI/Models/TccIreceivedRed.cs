using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccIreceivedRed
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
        public decimal? ProjectSchedule { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectCategorySub { get; set; }
        public string ProjectCategoryInfo { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ContractCategory { get; set; }
        public string ContractForm { get; set; }
        public decimal? ContractAmount { get; set; }
        public decimal? ContractPaymentAmount { get; set; }
        public decimal? ContractPaymentPercentage { get; set; }
        public string UnitJnw { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public decimal? AggregateRecInvoiceAmount { get; set; }
        public decimal? AggregateRecReceiptAmount { get; set; }
        public decimal? AggregateWithholdingTax { get; set; }
        public decimal? TotelReturnTax { get; set; }
        public string PaymentCategory { get; set; }
        public string ContractCurrency { get; set; }
        public string InvoicesUnitName { get; set; }
        public string SignCode { get; set; }
        public string SignName { get; set; }
        public decimal? InvoiceTotalAmount { get; set; }
        public decimal? InvoiceTotalBillAmount { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public int? VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public string CasierClaimUserName { get; set; }
        public string CasierClaimLoginUserName { get; set; }
        public DateTime? CasierClaimDate { get; set; }
        public string AccountingAuditUserName { get; set; }
        public string AccountingAuditLoginUserName { get; set; }
        public DateTime? AccountingAuditDate { get; set; }
        public int? Attachment { get; set; }
        public string ProjectCodeDev { get; set; }
        public int? RequestType { get; set; }
        public string ApplicationName { get; set; }
        public int? ApplicationCode { get; set; }
        public string ReMark { get; set; }
    }
}
