using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPaymentHistoryTotal
    {
        public long Rss { get; set; }
        public long? Rowss { get; set; }
        public int? Id { get; set; }
        public int? Ppid { get; set; }
        public int? Pppid { get; set; }
        public int? Tsid { get; set; }
        public DateTime? RequestDate { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectId { get; set; }
        public int? RequestPayCategory { get; set; }
        public string RequestPayCategoryName { get; set; }
        public string RequestRealName { get; set; }
        public int? PaymentNode { get; set; }
        public string PaymentNodeName { get; set; }
        public string PaymentDescription { get; set; }
        public string ContractCode { get; set; }
        public string CompanyName { get; set; }
        public string Currency { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? PaymentPayableAmount { get; set; }
        public decimal? PaymentWithholdingAmount { get; set; }
        public decimal? PaymentActualPayments { get; set; }
        public decimal? WithholdingTax { get; set; }
        public decimal? OtherCost { get; set; }
        public decimal? PaymentOtherPaymentTotal { get; set; }
        public decimal? Sheamount { get; set; }
        public decimal? InputVat { get; set; }
        public string PaymentMethodName { get; set; }
        public int? PaymentMethod { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? ChangeLocalCurrencyAmount { get; set; }
        public string PaymentCodes { get; set; }
        public string Operater { get; set; }
        public decimal? FineAmount { get; set; }
        public decimal? WithoutInputVat { get; set; }
        public decimal? WithoutOtherTax { get; set; }
        public decimal? AccountPaid { get; set; }
        public decimal? PaymentContractAmount { get; set; }
        public decimal? OtherBuy { get; set; }
        public string MainContractCurrency { get; set; }
        public decimal? MainExchange { get; set; }
        public decimal? MainRmb { get; set; }
        public int? ApplicationCode { get; set; }
        public DateTime? AccountingTime { get; set; }
        public string Phidnumber { get; set; }
        public string Poidnumber { get; set; }
        public string ApplicationName { get; set; }
        public decimal? TotalPayment { get; set; }
    }
}
