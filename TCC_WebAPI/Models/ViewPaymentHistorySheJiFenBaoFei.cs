using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPaymentHistorySheJiFenBaoFei
    {
        public int? Id { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestFormNumber { get; set; }
        public int? RequestType { get; set; }
        public string RequestTypeName { get; set; }
        public int? RequestPayCategory { get; set; }
        public string RequestPayCategoryName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public double? PaymentAmountLowercase { get; set; }
        public string PaymentCurrency { get; set; }
        public double? FinanceChangeLocalCurrencyAmount { get; set; }
        public string PaymentReceivingCompanyCode { get; set; }
        public string PaymentReceivingCompanyName { get; set; }
        public string SignSupplierCode { get; set; }
        public string SignSupplierName { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string Fy { get; set; }
        public int? IYear { get; set; }
        public int? IQuarter { get; set; }
        public int Flag { get; set; }
        public string Xmgs { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentFlag { get; set; }
    }
}
