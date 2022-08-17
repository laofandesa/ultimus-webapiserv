using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAddNewPaymentInfo
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string PaymentReceivingCompanyCode { get; set; }
        public string PaymentReceivingCompanyName { get; set; }
        public string PaymentReceivingCompanyAddress { get; set; }
        public string PaymentBankName { get; set; }
        public string PaymentBankAddress { get; set; }
        public string PaymentBankAccount { get; set; }
        public string PaymentLineNumbers { get; set; }
        public string PaymentSwiftCode { get; set; }
        public string PaymentIbanCode { get; set; }
        public string PaymentAbacode { get; set; }
        public decimal? PaymentTotal { get; set; }
        public decimal? PaymentOtherPaymentTotal { get; set; }
        public decimal? PaymentInputVat { get; set; }
        public decimal? PaymentWithoutInputVat { get; set; }
        public decimal? PaymentWithoutOtherTax { get; set; }
        public decimal? WithdholdingTax { get; set; }
        public decimal? FineAmount { get; set; }
        public decimal? OtherCost { get; set; }
        public decimal? PaymentBillAmount { get; set; }
        public string AddPaymentCurrency { get; set; }
        public decimal? PaymentActualTotal { get; set; }
        public decimal? PaymentActualInputVat { get; set; }
    }
}
