using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccLetterOfCreditGatherChange
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
        public int? RequestType { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelephone { get; set; }
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
        public int? RequestLccategory { get; set; }
        public string RequestLccategoryName { get; set; }
        public string RequestPaymentNode { get; set; }
        public string RequestPaymentNodeName { get; set; }
        public int? RequestPaymentTimer { get; set; }
        public DateTime? RequestOpeningDate { get; set; }
        public DateTime? RequestDueDate { get; set; }
        public int? RequestDueDay { get; set; }
        public string RequestLccurrency { get; set; }
        public decimal? RequestLcamt { get; set; }
        public decimal? RequestExchange { get; set; }
        public decimal? RequestLcrmb { get; set; }
        public string RequestDescription { get; set; }
        public string HdId { get; set; }
        public int? ModifyType { get; set; }
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
    }
}
