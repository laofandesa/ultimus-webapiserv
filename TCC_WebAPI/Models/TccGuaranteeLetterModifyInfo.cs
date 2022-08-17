using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccGuaranteeLetterModifyInfo
    {
        public string ModId { get; set; }
        public string HdId { get; set; }
        public int ModifyType { get; set; }
        public string ModifyOpinion { get; set; }
        public DateTime? EndDate { get; set; }
        public string WithdrawPersonLoginName { get; set; }
        public string WithdrawPersonRealName { get; set; }
        public string WithdrawPersonUserIdentity { get; set; }
        public DateTime WithdrawDate { get; set; }
        public decimal? PreClaimAmt { get; set; }
        public decimal? ClaimAmt { get; set; }
        public int Incident { get; set; }
        public string ProcessName { get; set; }
        public DateTime? ClaimAmtRecvDate { get; set; }
        public DateTime ModApplyDate { get; set; }
        public int ProcessStatus { get; set; }
        public int? ClaimSucceeded { get; set; }
        public int? IsSue { get; set; }
        public int? SueSucceeded { get; set; }
        public string GrtLtCode { get; set; }
        public decimal? ChangedAmt { get; set; }
        public decimal? ChangeRmbAmt { get; set; }
        public decimal? ExchangeRate { get; set; }
    }
}
