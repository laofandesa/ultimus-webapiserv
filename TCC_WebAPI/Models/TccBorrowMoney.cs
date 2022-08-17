using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBorrowMoney
    {
        public int Id { get; set; }
        public string MainProcessName { get; set; }
        public int? MainIncident { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public string CardNo { get; set; }
        public string IsAccepted { get; set; }
        public string AcceptedRemark { get; set; }
        public DateTime? TravelBeginDate { get; set; }
        public DateTime? TravelEndDate { get; set; }
        public int? TotalDays { get; set; }
        public int? TotalHours { get; set; }
        public int? TotalMinutes { get; set; }
        public string IsBorrowMoney { get; set; }
        public string Telephone { get; set; }
        public int? BorrowType { get; set; }
        public string BorrowTypeText { get; set; }
        public int? HaveBorrow { get; set; }
        public string HaveBorrowText { get; set; }
        public decimal? NoRepayMentAmount { get; set; }
        public string BorrowPurpose { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string PaymentType { get; set; }
        public string OfficialCard { get; set; }
        public string PartnerCompanyName { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string UnitedBankNumber { get; set; }
        public decimal? BorrowMoneySmall { get; set; }
        public string BorrowMoneyBig { get; set; }
        public string BorrowMoneyRemark { get; set; }
        public int? AttachmentNum { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string PayPayMentType { get; set; }
        public string PayPayBankName { get; set; }
        public DateTime? PayPayDate { get; set; }
        public decimal? PayMoney { get; set; }
        public string PayAccountSubject { get; set; }
        public string PayCheque { get; set; }
        public int? IsChildProcess { get; set; }
        public int? IsLink { get; set; }
        public int? IsAccount { get; set; }
        public string UseInstructions { get; set; }
        public string BussinessCard { get; set; }
        public string IsCompleted { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmFinaceLoginName { get; set; }
        public string ConfirmFinaceUserIdentity { get; set; }
        public string ConfirmStatus { get; set; }
        public DateTime? ConfirmFinacedAte { get; set; }
        public int? Voucherid { get; set; }
        public string Transactor { get; set; }
        public string PartnerName { get; set; }
        public string AuditAccountName { get; set; }
        public string AuditAccountLoginName { get; set; }
        public string AuditAccountUserIdentity { get; set; }
        public int? Location { get; set; }
        public int? BusinessObject { get; set; }
        public int? Currency { get; set; }
        public string CurrencySubjectCode { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public decimal? MoneyYb { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Quota { get; set; }
        public string PartnerNameloginname { get; set; }
        public int? ToDomesticOversea { get; set; }
        public string NoRepayCurrency { get; set; }
        public string AbroadBankAccount { get; set; }
        public string AbroadBankName { get; set; }
        public string AbroadAccountName { get; set; }
    }
}
