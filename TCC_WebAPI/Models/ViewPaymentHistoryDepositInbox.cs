using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPaymentHistoryDepositInbox
    {
        public int? Id { get; set; }
        public string RequestLoginName { get; set; }
        public string RequsetSfzh { get; set; }
        public string RequestRealName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestFormNumber { get; set; }
        public int? RequestPayCategory { get; set; }
        public string RequestPayCategoryName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string RequestDepartCode { get; set; }
        public string RequestDepartName { get; set; }
        public DateTime? AccountingTime { get; set; }
        public int? PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public string Currency { get; set; }
        public decimal? ChangeLocalCurrencyAmount { get; set; }
        public decimal? Exchange { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string PaymentCodes { get; set; }
        public string SignSupplierCode { get; set; }
        public string SignSupplierName { get; set; }
        public string PaymentBankName { get; set; }
        public string PaymentBankAddress { get; set; }
        public string PaymentBankAccount { get; set; }
        public string PaymentReceivingCompanyAddress { get; set; }
        public string PaymentLineNumbers { get; set; }
        public string PaymentSwiftCode { get; set; }
        public string PaymentIbanCode { get; set; }
        public string PaymentAbacode { get; set; }
        public string DepartCode { get; set; }
        public string DepartName { get; set; }
    }
}
