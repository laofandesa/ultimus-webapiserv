using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBillsManagement
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string BillSource { get; set; }
        public int? BillCategoryValue { get; set; }
        public string BillCategoryText { get; set; }
        public int? AccountStatus { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string BillCode { get; set; }
        public string BillContent { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillTaxAmount { get; set; }
        public string TaxRateCode { get; set; }
        public string TaxRateText { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? Amount { get; set; }
        public string TransactorLoginName { get; set; }
        public string TransactorRealName { get; set; }
        public string TransactorIdentity { get; set; }
        public DateTime? RecDate { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string ConfirmLoginName { get; set; }
        public string ConfirmRealName { get; set; }
        public string ConfirmIdentity { get; set; }
        public int? BillStatus { get; set; }
        public string NeedAccount { get; set; }
        public int? Vchrnum { get; set; }
        public string PaymentCategory { get; set; }
        public string ContanctCode { get; set; }
        public int? IsTs { get; set; }
        public string UnitJnw { get; set; }
        public string RelevanceInvoiceCategoryText { get; set; }
        public int? RelevanceInvoiceCategoryValue { get; set; }
        public int? GoodClass { get; set; }
        public string InvoicesUnitName { get; set; }
        public int? Inventory { get; set; }
        public decimal? ExdrawbackTax { get; set; }
        public string FormNumber { get; set; }
        public string ReceiptorRealName { get; set; }
        public string ReceiptorIdentity { get; set; }
        public DateTime? ReceiptTime { get; set; }
        public string ProjectJnw { get; set; }
        public string ProjectCodeMain { get; set; }
        public decimal? BillAmountRmb { get; set; }
        public decimal? BillTaxAmountRmb { get; set; }
        public decimal? AmountRmb { get; set; }
        public string Currency { get; set; }
        public decimal? Exchange { get; set; }
        public int? CalculateMode { get; set; }
        public int? DeleteFlag { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string DeleteUser { get; set; }
        public string InvoiceCode { get; set; }
        public DateTime? CreatDate { get; set; }
        public DateTime? AccountDate { get; set; }
        public string ProofCode { get; set; }
        public string VchemInfo { get; set; }
        public decimal? BillAmountCnt { get; set; }
        public decimal? BillTaxAmountCnt { get; set; }
        public decimal? ExchangeCnt { get; set; }
    }
}
