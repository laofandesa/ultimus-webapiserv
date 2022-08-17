using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBusinessAskForLeave
    {
        public int Id { get; set; }
        public string MainProcessName { get; set; }
        public int? MainIncident { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public string BussinessCard { get; set; }
        public string Telephone { get; set; }
        public int? ToDomesticOversea { get; set; }
        public string ToCountry { get; set; }
        public string ToCity { get; set; }
        public int? TravelType { get; set; }
        public string TravelType1 { get; set; }
        public string TaskTarget { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string InviteUnit { get; set; }
        public DateTime? AskForLeaveBeginDate { get; set; }
        public DateTime? AskForLeaveEndDate { get; set; }
        public int? TotalDays { get; set; }
        public string IsAccepted { get; set; }
        public string IsBorrowMoney { get; set; }
        public int? HaveBorrow { get; set; }
        public string HaveBorrowText { get; set; }
        public string RejectRemark { get; set; }
        public int? Location { get; set; }
        public string LocationAdress { get; set; }
        public int? PaymentType { get; set; }
        public string PayType { get; set; }
        public decimal? NoRepayMentAmount { get; set; }
        public string Currency { get; set; }
        public string CurrencyType { get; set; }
        public string CurrencySubjectCode { get; set; }
        public decimal? MoneyYb { get; set; }
        public decimal? Rate { get; set; }
        public decimal? BorrowMoneySmall { get; set; }
        public string BorrowMoneyBig { get; set; }
        public int? AttachmentNum { get; set; }
        public string FPayMentType { get; set; }
        public decimal? FPayMoney { get; set; }
        public DateTime? FPayDate { get; set; }
        public string FAccountSubject { get; set; }
        public string FAccountSubjectName { get; set; }
        public string FPayBankCode { get; set; }
        public string FPayBankName { get; set; }
        public string FCheque { get; set; }
        public string FTransactor { get; set; }
        public int? IsLink { get; set; }
        public int? IsAccount { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmFinaceLoginName { get; set; }
        public string ConfirmFinaceUserIdentity { get; set; }
        public string ConfirmStatus { get; set; }
        public DateTime? ConfirmFinaceDate { get; set; }
        public int? Voucherid { get; set; }
        public string AuditAccountName { get; set; }
        public string AuditAccountLoginName { get; set; }
        public string AuditAccountUserIdentity { get; set; }
        public int? BusinessObject { get; set; }
        public string IsAbort { get; set; }
        public string AskForLeaveLoginName { get; set; }
        public string AskForLeaveRealName { get; set; }
        public string AskForLeaveIdentity { get; set; }
        public DateTime? AskForLeaveDate { get; set; }
        public string BusinesTripRealName { get; set; }
        public string BusinesTripTravelPersons { get; set; }
        public int? Flag { get; set; }
    }
}
