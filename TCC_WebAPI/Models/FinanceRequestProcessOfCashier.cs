using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessOfCashier
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public int? ReceiveMethodType { get; set; }
        public string PayorName { get; set; }
        public string PayCmpBank { get; set; }
        public string PayCmpBankAcct { get; set; }
        public string PayCmpBankUnionAcct { get; set; }
        public decimal? ReceiveAmount { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmFinaceLoginName { get; set; }
        public DateTime? ConfirmFinaceDate { get; set; }
        public string AuditAccountName { get; set; }
        public string AuditAccountLoginName { get; set; }
        public DateTime? AuditAccountDate { get; set; }
        public string PayBankCode { get; set; }
        public string PayBankName { get; set; }
        public string PayCheque { get; set; }
        public string AnnexaNumber { get; set; }
        public int? Voucherid { get; set; }
        public string PayCmpCode { get; set; }
        public int? ConfirmStatus { get; set; }
        public decimal? Rate { get; set; }
        public decimal? MoneyRmb { get; set; }
        public decimal? RateDifferential { get; set; }
        public decimal? RateOfYb { get; set; }
        public string TaxRate { get; set; }
        public int? TaxRateValue { get; set; }
        public decimal? SubMoneyOnVat { get; set; }
        public decimal? DesignOfIncome { get; set; }
        public string AccountPayCmpCode { get; set; }
        public string AccountPayCmpName { get; set; }
        public DateTime? AccountingTime { get; set; }
        public string AccountReceiveCmpCode { get; set; }
        public string AccountReceiveCmpName { get; set; }
        public int? RequestType { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string OffSingleNumber { get; set; }
        public string CustomsCode { get; set; }
        public string DigestDescribition { get; set; }
        public string VoucherBillTaxCurrency { get; set; }
        public decimal? VoucherBillTaxAmount { get; set; }
        public decimal? VoucherBillTaxAmountRmb { get; set; }
        public string VoucherTaxCurrency { get; set; }
        public decimal? VoucherTaxExchange { get; set; }
        public decimal? VoucherTaxAmount { get; set; }
    }
}
