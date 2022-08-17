using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportExpenseClaimHeader
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
        public string Agency { get; set; }
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
        public string LinkBorrowMoney { get; set; }
        public string BorrowMoney { get; set; }
        public string LoanCurrency { get; set; }
        public string RemainingBorrowMoney { get; set; }
        public string TravelTotalTrain { get; set; }
        public string TravelTotalAirPlane { get; set; }
        public string TravelTotalSteamShip { get; set; }
        public string TravelTotalLongTrip { get; set; }
        public string TravelTotalHotel { get; set; }
        public string TravelTotalBooking { get; set; }
        public string TravelTotalTraffic { get; set; }
        public string TravelTotalOther { get; set; }
        public string TotalExpense { get; set; }
        public string MoneyShallSmall { get; set; }
        public string MoneyShallBig { get; set; }
        public string MoneyActual { get; set; }
        public string DailyBudgetMoney { get; set; }
        public string DailyRemainingBudget { get; set; }
        public int? AttachmentNum { get; set; }
        public string OfficialCard { get; set; }
        public string ProcessFinishDate { get; set; }
        public string AccountSubject { get; set; }
        public string TravelDomesticOversea { get; set; }
        public int? TravelClaimPersons { get; set; }
        public string TravelToPlace { get; set; }
        public int? ApproverTotal { get; set; }
        public int? ApproverCount { get; set; }
        public string BeyondReason { get; set; }
        public string IsBeyond { get; set; }
        public string AccountStatus { get; set; }
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
        public string ConfirmFinaceDate { get; set; }
        public int? Voucherid { get; set; }
        public string PaymentType { get; set; }
        public string ConfirmAuditorName { get; set; }
        public string ConfirmAuditorLoginName { get; set; }
        public string ConfirmAuditorUserIdentity { get; set; }
        public string ConfirmAuditorDate { get; set; }
        public string AccountSubjectCode { get; set; }
        public string AccountSubjectName { get; set; }
        public string Transactor { get; set; }
        public string ProjectCategory { get; set; }
        public int? BusinessObject { get; set; }
        public int? ForeignId { get; set; }
        public string LinkBorrowMoneyOfForeign { get; set; }
        public string RemainMoneyOfForeign { get; set; }
        public string MoneyOfForeignRmb { get; set; }
        public string RateOfForeign { get; set; }
        public string Location { get; set; }
        public string SpecialOptions { get; set; }
        public int? ShowPayee { get; set; }
        public string Payee { get; set; }
        public string TelPhone { get; set; }
        public string LoanAccountingUnit { get; set; }
        public string LoanAccountingUnitName { get; set; }
        public string VchrnumCode { get; set; }
    }
}
