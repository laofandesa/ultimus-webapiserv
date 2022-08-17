using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccLetterOfCredit
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? Status { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ReceivingCompanyName { get; set; }
        public string ReceivingCompanyCode { get; set; }
        public int? Lccategory { get; set; }
        public string LccategoryName { get; set; }
        public string PaymentNode { get; set; }
        public string PaymentNodeName { get; set; }
        public int? PaymentTimer { get; set; }
        public DateTime? OpeningDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int? DueDay { get; set; }
        public string Lccurrency { get; set; }
        public decimal? Lcamt { get; set; }
        public decimal? Exchange { get; set; }
        public decimal? Lcrmb { get; set; }
        public string Lccode { get; set; }
        public string Beneficiary { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public int? IsDeposit { get; set; }
        public string DepositCurrency { get; set; }
        public decimal? DepositAmt { get; set; }
        public decimal? DepositExchange { get; set; }
        public decimal? DepositRmb { get; set; }
        public decimal? PaymentTotal { get; set; }
        public int? IsYuanQi { get; set; }
        public int? YuanQiTimer { get; set; }
        public DateTime? CasierClaimDate { get; set; }
        public string CasierClaimLoginUserName { get; set; }
        public string CasierClaimUserName { get; set; }
        public DateTime? AccountingAuditDate { get; set; }
        public string AccountingAuditLoginUserName { get; set; }
        public string AccountingAuditUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ContractUnitCode { get; set; }
        public string ContractUnitName { get; set; }
        public string SourceName { get; set; }
        public int? Flag { get; set; }
        public string ModifyType { get; set; }
        public int? IsSueForPay { get; set; }
        public decimal? SueAmt { get; set; }
        public int? SueInCash { get; set; }
        public int? IsDelay { get; set; }
        public int? OrigIsSetBack { get; set; }
        public string Judge { get; set; }
        public string Remark { get; set; }
        public DateTime? DelayEdDt { get; set; }
        public string HdId { get; set; }
        public string ModifyTypeName { get; set; }
        public int? IsEnable { get; set; }
    }
}
