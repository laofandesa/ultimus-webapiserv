using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentHistoryTmpForModifyHisoty
    {
        public int Id { get; set; }
        public int? Ppid { get; set; }
        public string RequestLoginName { get; set; }
        public string RequsetSfzh { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string RequestRealName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestFormNumber { get; set; }
        public int? RequestType { get; set; }
        public string RequestTypeName { get; set; }
        public int? RequestPayCategory { get; set; }
        public string RequestPayCategoryName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? ProjectType { get; set; }
        public decimal? ProjectContractAmount { get; set; }
        public decimal? ProjectPaymentAmount { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ContractCurrencyType { get; set; }
        public decimal? ContractAmountTotal { get; set; }
        public int? PaymentNode { get; set; }
        public string PaymentNodeName { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string DepartCode { get; set; }
        public string DepartName { get; set; }
        public DateTime? AccountingTime { get; set; }
        public int? PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public string Currency { get; set; }
        public decimal? ChangeLocalCurrencyAmount { get; set; }
        public string Handing { get; set; }
        public string HandingIdnumber { get; set; }
        public string Operater { get; set; }
        public string OperaterIdnumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? Exchange { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string ProjectCategory { get; set; }
        public string ContractCategory { get; set; }
        public string PaymentCodes { get; set; }
        public string PaymentDescription { get; set; }
        public int? Fcsid { get; set; }
        public decimal? PaymentPayableAmount { get; set; }
        public decimal? PaymentWithholdingAmount { get; set; }
        public decimal? PaymentActualPayments { get; set; }
        public decimal? WithholdingTax { get; set; }
        public decimal? OtherCost { get; set; }
        public decimal? PaymentOtherPaymentTotal { get; set; }
        public string SignSupplierCode { get; set; }
        public string SignSupplierName { get; set; }
        public decimal? ActualCurrencyPaymentAmount { get; set; }
        public decimal? ActualCurrencyPaymentExchange { get; set; }
        public string ActualCurrency { get; set; }
        public decimal? Sheamount { get; set; }
        public string LinkFormNumber { get; set; }
        public decimal? InputVat { get; set; }
        public decimal? WithoutInputVat { get; set; }
        public string ProjectCodeDev { get; set; }
        public int? ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public decimal? FineAmount { get; set; }
        public decimal? PayContractExchange { get; set; }
        public decimal? PaymentContractAmount { get; set; }
        public int? Pppid { get; set; }
        public int? VoucherId { get; set; }
        public decimal? WithoutOtherTax { get; set; }
        public decimal? OtherBuy { get; set; }
        public string MainContractCurrency { get; set; }
        public decimal? MainExchange { get; set; }
        public decimal? MainRmb { get; set; }
        public string Finalengineeringcost { get; set; }
    }
}
