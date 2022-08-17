using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccReceivablesProcess
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerName { get; set; }
        public string ProjectManagerIdentity { get; set; }
        public string IsEpc { get; set; }
        public string ContractNumber { get; set; }
        public string ContractName { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public int? ContractFormEpc { get; set; }
        public string ContractFormDesign { get; set; }
        public decimal? AmountContract { get; set; }
        public decimal? AmountAdd { get; set; }
        public decimal? AmountReduce { get; set; }
        public decimal? AmountTotal { get; set; }
        public int? ContractCurrency { get; set; }
        public string ContractCurrencyName { get; set; }
        public int? ReceivablesCategory { get; set; }
        public string ReceivablesCategoryName { get; set; }
        public decimal? CurrentReceivablesAmount { get; set; }
        public string CurrentReceivablesAmountBig { get; set; }
        public int? Currency { get; set; }
        public string CurrencyName { get; set; }
        public int? ReceivablesMethod { get; set; }
        public string ReceivablesMethodName { get; set; }
        public string PayCompanyName { get; set; }
        public string PayBankName { get; set; }
        public string PayBankAccount { get; set; }
        public string PayUnitedBankNumber { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string ReceivablesBankName { get; set; }
        public string ReceivablesBankAccount { get; set; }
        public DateTime? NotesIssuingDate { get; set; }
        public string NotesNo { get; set; }
        public decimal? NotesAmount { get; set; }
        public string AccountSubject { get; set; }
        public int? AccountStatus { get; set; }
    }
}
