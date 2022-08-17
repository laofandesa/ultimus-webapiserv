using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccLetterOfCreditOpenModifyInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string RequestSfzh { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestFormNumber { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string ProjectCodeDev { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public int? ContractType { get; set; }
        public string ContractCategory { get; set; }
        public string UnitJnw { get; set; }
        public string ReceivingCompanyName { get; set; }
        public string ReceivingCompanyCode { get; set; }
        public DateTime? ContractSignDate { get; set; }
        public string ContractCurrency { get; set; }
        public decimal? ContractAmt { get; set; }
        public string ContractFkfs { get; set; }
        public int? FinanceLccategory { get; set; }
        public string FinanceLccategoryName { get; set; }
        public string FinanceLccode { get; set; }
        public DateTime? FinanceOpeningDate { get; set; }
        public DateTime? FinanceDueDate { get; set; }
        public int? FinanceDueDay { get; set; }
        public string FinanceBeneficiary { get; set; }
        public string FinanceLccurrency { get; set; }
        public string FinanceBankName { get; set; }
        public string FinanceBankCode { get; set; }
        public decimal? FinanceLcamt { get; set; }
        public decimal? FinanceLcexchange { get; set; }
        public decimal? FinanceLcrmb { get; set; }
        public string HdId { get; set; }
        public string ModifyType { get; set; }
        public string ModifyOpinion { get; set; }
        public DateTime? EndDate { get; set; }
        public string WithdrawPersonLoginName { get; set; }
        public string WithdrawPersonRealName { get; set; }
        public string WithdrawPersonUserIdentity { get; set; }
        public DateTime? WithdrawDate { get; set; }
        public decimal? PreClaimAmt { get; set; }
        public decimal? ClaimAmt { get; set; }
        public DateTime? ClaimAmtRecvDate { get; set; }
        public DateTime? ModApplyDate { get; set; }
        public int? ClaimSucceeded { get; set; }
        public int? IsSue { get; set; }
        public int? SueSucceeded { get; set; }
        public string ModifyTypeName { get; set; }
        public string ContractUnitName { get; set; }
        public string FinanceCalculateMode { get; set; }
        public DateTime? RequestCollectTime { get; set; }
        public int? RequestPaymentTimer { get; set; }
        public string RequestDescription { get; set; }
    }
}
