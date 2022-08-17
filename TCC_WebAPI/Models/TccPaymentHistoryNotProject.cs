using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentHistoryNotProject
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
        public string RequestDepartCode { get; set; }
        public string RequestDepartName { get; set; }
        public DateTime? AccountingTime { get; set; }
        public int? PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public string Currency { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? ChangeLocalCurrencyAmount { get; set; }
        public string Handing { get; set; }
        public string HandingIdnumber { get; set; }
        public string Operater { get; set; }
        public string OperaterIdnumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? Exchange { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string PaymentDescription { get; set; }
        public string PaymentCodes { get; set; }
        public int? IsContract { get; set; }
        public int? Location { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public decimal? ContractAmount { get; set; }
        public int? ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public string SignSupplierCode { get; set; }
        public string SignSupplierName { get; set; }
        public int? PaymentNode { get; set; }
        public string PaymentNodeName { get; set; }
        public string PaymentVoucherDeptCode { get; set; }
        public string PaymentVoucherDeptName { get; set; }
        public int? Pppid { get; set; }
        public string ContractCurrencyType { get; set; }
        public int? VoucherId { get; set; }
        public decimal? PaymentApplyAmount { get; set; }
        public decimal? InputVat { get; set; }
        public decimal? WithoutInputVat { get; set; }
        public decimal? OtherTax { get; set; }
    }
}
