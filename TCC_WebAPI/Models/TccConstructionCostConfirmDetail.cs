using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccConstructionCostConfirmDetail
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string ProjectCode { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ContractType { get; set; }
        public string ContractCategory { get; set; }
        public string ContractForm { get; set; }
        public string ContractCurrencyType { get; set; }
        public decimal? ContractAmountContract { get; set; }
        public decimal? ContractAmountChange { get; set; }
        public decimal? ContractAmountTotal { get; set; }
        public decimal? ContractAmountTotalChangeLocal { get; set; }
        public string PaymentReceivingCompanyName { get; set; }
        public string PaymentReceivingCompanyAddress { get; set; }
        public string PaymentBankName { get; set; }
        public string PaymentBankAccount { get; set; }
        public string PaymentLineNumbers { get; set; }
        public string PaymentReceivingCompanyCode { get; set; }
        public string ContractUnitName { get; set; }
        public string ContractUnitCode { get; set; }
        public string SignSupplierName { get; set; }
        public string SignSupplierCode { get; set; }
        public string UnitJnw { get; set; }
        public string ProjName { get; set; }
        public decimal? AlPayAmount { get; set; }
        public decimal? AlPayAmountRmb { get; set; }
        public decimal? ContractRate { get; set; }
        public decimal? ReceiveBillAmount { get; set; }
        public decimal? ConfirmedAmount { get; set; }
        public decimal? ConfirmAmount { get; set; }
        public decimal? ConfirmAmountTotal { get; set; }
        public string PerAlComplete { get; set; }
    }
}
