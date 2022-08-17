using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportEntertainmentClaim
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestDate { get; set; }
        public string RequestFormNumber { get; set; }
        public string VchrnumCode { get; set; }
        public string EntertainCategory { get; set; }
        public string PersonLevel { get; set; }
        public string BorrowMoney { get; set; }
        public string LoanCurrency { get; set; }
        public string BorrowMoneyZzj { get; set; }
        public string LoanCurrencyzzj { get; set; }
        public string LinkBorrow { get; set; }
        public string LinkBorrowMoney { get; set; }
        public string RemainingBorrowMoney { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string MoneyShallSmall { get; set; }
        public string MoneyShallBig { get; set; }
        public decimal? MoneyActual { get; set; }
        public string BudgetMoney { get; set; }
        public string RemainingBudget { get; set; }
        public int? AttachmentNum { get; set; }
        public string OfficialCard { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string AccountSubject { get; set; }
        public int? AccountStatus { get; set; }
        public string VisitorUnitName { get; set; }
        public string NumberOfVisitor { get; set; }
        public string TheMaster { get; set; }
        public string ToAccompany { get; set; }
        public string RequestUserIdentity { get; set; }
        public decimal? CompanyBudgetMoney { get; set; }
        public decimal? CompanyRemainingBudget { get; set; }
        public string PayBankName { get; set; }
        public string PayCheque { get; set; }
        public string PayBankCode { get; set; }
        public string BussinessCard { get; set; }
        public string EntertainName { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmFinaceLoginName { get; set; }
        public string ConfirmFinaceUserIdentity { get; set; }
        public string ConfirmStatus { get; set; }
        public DateTime? ConfirmFinaceDate { get; set; }
        public int? Voucherid { get; set; }
        public string ClaimsDepartmentCode { get; set; }
        public string ClaimsDepartmentName { get; set; }
        public string PaymentType { get; set; }
        public string PaymentTypeText { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectManagerName { get; set; }
        public string Subjectcode { get; set; }
        public string SubjectName { get; set; }
        public string Transactor { get; set; }
        public string AuditAccountName { get; set; }
        public string AuditAccountLoginName { get; set; }
        public string AuditAccountUserIdentity { get; set; }
        public string Location { get; set; }
        public int? BusinessObject { get; set; }
        public int? Fps { get; set; }
        public int? ForeignId { get; set; }
        public string ForeignText { get; set; }
        public string LinkBorrowMoneyOfForeign { get; set; }
        public string RemainMoneyOfForeign { get; set; }
        public string MoneyOfForeignRmb { get; set; }
        public decimal? RateOfForeign { get; set; }
        public string VisaLoginName { get; set; }
        public string VisaRealName { get; set; }
        public string VisaUserIdentity { get; set; }
        public string VisaDeptCode { get; set; }
        public string VisaDeptName { get; set; }
        public string Cj { get; set; }
        public string Agency { get; set; }
        public string Currency { get; set; }
        public string CurrencyName { get; set; }
        public string BorrowPerson { get; set; }
        public string BorrowPersonIdentity { get; set; }
        public string BearUnitCode { get; set; }
        public string BearUnitName { get; set; }
        public int? Bz { get; set; }
        public int? BorrowTypeCode { get; set; }
        public string BorrowTypeName { get; set; }
        public int? BorrowUse { get; set; }
        public string LinkBorrowMoneyofproject { get; set; }
        public string RemainingBorrowMoneyofproject { get; set; }
        public decimal? Exchange { get; set; }
        public decimal? BorrowMoneyofRmbproject { get; set; }
    }
}
