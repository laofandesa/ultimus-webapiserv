using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportGeneralExpensesHeader
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestUserPost { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelPhone { get; set; }
        public string RequestDate { get; set; }
        public string RequestFinishDate { get; set; }
        public string FormNumber { get; set; }
        public string Agency { get; set; }
        public string VisaUserPost { get; set; }
        public string VisaRealName { get; set; }
        public string VisaLoginName { get; set; }
        public string VisaUserIdentity { get; set; }
        public string VisaDeptCode { get; set; }
        public string VisaDeptName { get; set; }
        public int? DataSource { get; set; }
        public string DataSourceText { get; set; }
        public string Location { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public string ClaimsDepartmentCode { get; set; }
        public string ClaimsDepartmentName { get; set; }
        public string PaymentFormNumber { get; set; }
        public string BorrowMoneyByj { get; set; }
        public string LoanCurrencybyj { get; set; }
        public string BorrowMoneyZzj { get; set; }
        public string LoanCurrencyzzj { get; set; }
        public string BudgetMoney { get; set; }
        public string RemainBudget { get; set; }
        public string ReimburseMoney { get; set; }
        public string MoneyShallSmall { get; set; }
        public string MoneyShallBig { get; set; }
        public string MoneyActual { get; set; }
        public int? IsBeyond { get; set; }
        public string BeyondReason { get; set; }
        public string ConfirmStatus { get; set; }
        public string ConfirmDate { get; set; }
        public int? Voucherid { get; set; }
        public string BussinessCard { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmFinaceLoginName { get; set; }
        public string ConfirmFinaceUserIdentity { get; set; }
        public string ConfirmAuditName { get; set; }
        public string ConfirmAuditLoginName { get; set; }
        public string ConfirmAuditUserIdentity { get; set; }
        public int? BusinessObject { get; set; }
        public int? ExpenseTypeCode { get; set; }
        public string ExpenseTypeName { get; set; }
        public string NeedDirector { get; set; }
        public string LinkBorrowMoney { get; set; }
        public string RemainingBorrowMoney { get; set; }
        public string PayorBank { get; set; }
        public string PayorBankCode { get; set; }
        public string BankAccount { get; set; }
        public int? PaymentMethod { get; set; }
        public string PaymentType { get; set; }
        public string Tractor { get; set; }
        public int? AttachmentNum { get; set; }
        public string Currency { get; set; }
        public string CurrencyName { get; set; }
        public int? BorrowTypeCode { get; set; }
        public string BorrowTypeName { get; set; }
        public int? BorrowUse { get; set; }
        public decimal? RateOfForeign { get; set; }
        public string MoneyOfForeignRmb { get; set; }
        public string BorrowPerson { get; set; }
        public string BorrowPersonIdentity { get; set; }
        public string BearUnitCode { get; set; }
        public string BearUnitName { get; set; }
        public string Bz { get; set; }
        public int? ShowPayee { get; set; }
        public string Payee { get; set; }
        public string ProjectJnw { get; set; }
        public int? IsthirdPay { get; set; }
        public string VchrnumCode { get; set; }
    }
}
