using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimHeaderTemp
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
        public int? Agency { get; set; }
        public string FormNumber { get; set; }
        public string ExpenseCategory { get; set; }
        public string TravelClaimCategory { get; set; }
        public string TravelCategory { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? TravelClaimDays { get; set; }
        public string TravelRemark { get; set; }
        public string LinkBusinessTrip { get; set; }
        public string LinkBorrow { get; set; }
        public decimal? LinkBorrowMoney { get; set; }
        public decimal? BorrowMoney { get; set; }
        public decimal? RemainingBorrowMoney { get; set; }
        public decimal? TravelTotalTrain { get; set; }
        public decimal? TravelTotalAirPlane { get; set; }
        public decimal? TravelTotalSteamShip { get; set; }
        public decimal? TravelTotalLongTrip { get; set; }
        public decimal? TravelTotalHotel { get; set; }
        public decimal? TravelTotalBooking { get; set; }
        public decimal? TravelTotalTraffic { get; set; }
        public decimal? TravelTotalOther { get; set; }
        public decimal? TotalExpense { get; set; }
        public decimal? MoneyShallSmall { get; set; }
        public string MoneyShallBig { get; set; }
        public decimal? MoneyActual { get; set; }
        public decimal? DailyBudgetMoney { get; set; }
        public decimal? DailyRemainingBudget { get; set; }
        public int? DailyAttachmentNum { get; set; }
        public string OfficialCard { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string AccountSubject { get; set; }
        public int? TravelDomesticOversea { get; set; }
        public int? TravelClaimPersons { get; set; }
        public string TravelToPlace { get; set; }
        public int? ApproverTotal { get; set; }
        public int? ApproverCount { get; set; }
        public string BeyondReason { get; set; }
        public int? IsBeyond { get; set; }
        public int? AccountStatus { get; set; }
        public string IfNotProject { get; set; }
        public string PayorBank { get; set; }
        public string BankAccount { get; set; }
        public string PayorBankCode { get; set; }
        public string RequestUserIdentity { get; set; }
        public string ClaimsDepartmentCode { get; set; }
        public string ClaimsDepartmentName { get; set; }
        public string ClaimsDepartmentCodeTravel { get; set; }
        public string ClaimsDepartmentNameTravel { get; set; }
        public string BussinessCard { get; set; }
        public string ExpenseName { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmUserIdentity { get; set; }
        public string ConfirmLoginName { get; set; }
        public string ConfirmStatus { get; set; }
        public DateTime? ConfirmFinaceDate { get; set; }
        public int? Voucherid { get; set; }
        public string PaymentType { get; set; }
        public string ConfirmAuditorName { get; set; }
        public string ConfirmAuditorLoginName { get; set; }
        public string ConfirmAuditorUserIdentity { get; set; }
        public DateTime? ConfirmAuditorDate { get; set; }
        public string AccountSubjectCode { get; set; }
        public string AccountSubjectName { get; set; }
        public string Transactor { get; set; }
        public string ProjectCategory { get; set; }
        public int? BusinessObject { get; set; }
        public int? ForeignId { get; set; }
        public decimal? LinkBorrowMoneyOfForeign { get; set; }
        public decimal? RemainMoneyOfForeign { get; set; }
        public decimal? MoneyOfForeignRmb { get; set; }
        public decimal? RateOfForeign { get; set; }
        public int? Location { get; set; }
        public int? SpecialOptions { get; set; }
        public int? ShowPayee { get; set; }
        public int? Payee { get; set; }
        public string TelPhone { get; set; }
        public string LoanCurrency { get; set; }
        public string LoanAccountingUnit { get; set; }
        public string LoanAccountingUnitName { get; set; }
        public int? ProjectByBranch { get; set; }
        public string ProjectOwnership { get; set; }
        public int? IsExtendred { get; set; }
        public string IsTianjinRegion { get; set; }
        public string IsTjSideTravel { get; set; }
        public string BillConfirmUserLogin { get; set; }
        public string BillConfirmUserName { get; set; }
    }
}
