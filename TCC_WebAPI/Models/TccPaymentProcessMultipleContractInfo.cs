using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleContractInfo
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ContractForm { get; set; }
        public string ContractCategory { get; set; }
        public string ContractCurrencyType { get; set; }
        public decimal? ContractAmountContract { get; set; }
        public decimal? ContractAmountChange { get; set; }
        public decimal? ContractAmountTotal { get; set; }
        public string ContractUnitName { get; set; }
        public string ContractUnitCode { get; set; }
        public decimal? ContractAmountTotalPayment { get; set; }
        public decimal? ContractAmountTotalPaymentPercentage { get; set; }
        public decimal? ContractAmountTotalTimePayment { get; set; }
        public decimal? ContractAmountTotalTimePaymentPercentage { get; set; }
        public decimal? ChangeLocalCurrencyAmount { get; set; }
        public decimal? ContractAmountTotalApplyPayment { get; set; }
        public decimal? ContractAmountTotalApplyPaymentPercentage { get; set; }
        public int? ContractLg1 { get; set; }
        public int? ContractLg2 { get; set; }
        public int? ContractLg3 { get; set; }
        public string ContractLginto { get; set; }
        public decimal? ContractActualPaymentsTotal { get; set; }
        public decimal? ContractActualPaymentsTotalPercentage { get; set; }
        public decimal? ContractPayableAmountTotal { get; set; }
        public decimal? ContractPayableAmountTotalPercentage { get; set; }
        public decimal? ContractWithholdingAmountTotal { get; set; }
        public decimal? ContractWithholdingAmountTotalPercentage { get; set; }
        public decimal? ContractAmountTotalApplyPayablePayment { get; set; }
        public decimal? ContractAmountTotalApplyPayablePaymentPercentage { get; set; }
        public decimal? ContractAmountTotalTimePayablePayment { get; set; }
        public decimal? ContractAmountTotalTimePayablePaymentPercentage { get; set; }
        public decimal? ContractAmountTotalWithholdingTax { get; set; }
        public string ContractProjectCode { get; set; }
        public string ContractProjectName { get; set; }
        public decimal? ContractAmountTotalOtherPayment { get; set; }
        public decimal ContractAmountTotalTimeOtherPayment { get; set; }
        public decimal? ContractAmountTotalApplyOtherPayment { get; set; }
        public decimal? ContractWithholdingAmountTotalTimePayments { get; set; }
        public int? ContractIncludeTax { get; set; }
        public decimal? ContractTax { get; set; }
        public decimal? ContractTotalAmount { get; set; }
        public string ContSid { get; set; }
        public decimal? ContractExchange { get; set; }
        public decimal? ContractOtherBuyAmount { get; set; }
        public decimal? ContractOtherBuyTotal { get; set; }
        public decimal? ContractOtherBuyPaymentAmount { get; set; }
        public decimal? ContractOtherBuyTotalTimeAmount { get; set; }
        public int? CalculateMode { get; set; }
        public int? DecimalDigit { get; set; }
        public string MainContractCurrency { get; set; }
        public int? IsMainContract { get; set; }
        public string OtherBuyContractCode { get; set; }
        public string Lcinfo { get; set; }
        public string Lcper { get; set; }
        public string LawsuitSid { get; set; }
        public string LawsuitDSid { get; set; }
    }
}
