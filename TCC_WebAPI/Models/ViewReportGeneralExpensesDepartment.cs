using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportGeneralExpensesDepartment
    {
        public int? Id { get; set; }
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
        public DateTime? RequestDate { get; set; }
        public DateTime? RequestFinishDate { get; set; }
        public string FormNumber { get; set; }
        public int? Agency { get; set; }
        public string VisaUserPost { get; set; }
        public string VisaRealName { get; set; }
        public string VisaLoginName { get; set; }
        public string VisaUserIdentity { get; set; }
        public string VisaDeptCode { get; set; }
        public string VisaDeptName { get; set; }
        public int? DataSource { get; set; }
        public string DataSourceText { get; set; }
        public int? Location { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public string ClaimsDepartmentCode { get; set; }
        public string ClaimsDepartmentName { get; set; }
        public string PaymentFormNumber { get; set; }
        public decimal? BorrowMoneyByj { get; set; }
        public string LoanCurrencybyj { get; set; }
        public decimal? BorrowMoneyZzj { get; set; }
        public string LoanCurrencyzzj { get; set; }
        public decimal? BudgetMoney { get; set; }
        public decimal? RemainBudget { get; set; }
        public decimal? ReimburseMoney { get; set; }
        public decimal? MoneyShallSmall { get; set; }
        public string MoneyShallBig { get; set; }
        public decimal? MoneyActual { get; set; }
        public int? IsBeyond { get; set; }
        public string BeyondReason { get; set; }
        public int? ConfirmStatus { get; set; }
        public DateTime? ConfirmDate { get; set; }
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
        public decimal? LinkBorrowMoney { get; set; }
        public decimal? RemainingBorrowMoney { get; set; }
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
        public decimal? MoneyOfForeignRmb { get; set; }
        public string BorrowPerson { get; set; }
        public string BorrowPersonIdentity { get; set; }
        public string BearUnitCode { get; set; }
        public string BearUnitName { get; set; }
        public int? Bz { get; set; }
        public int? ShowPayee { get; set; }
        public int? Payee { get; set; }
        public string ProjectJnw { get; set; }
        public int? IsthirdPay { get; set; }
        public int? Pid { get; set; }
        public string ExpenseType { get; set; }
        public string DprojectCode { get; set; }
        public string DepartmentName { get; set; }
        public string PaymentAmount { get; set; }
    }
}
