using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTransportSubsidyInfoHeader
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
        public int? Location { get; set; }
        public string ClaimCategory { get; set; }
        public string ClaimsDepartmentCode { get; set; }
        public string ClaimsDepartmentName { get; set; }
        public decimal? MoneyShallSmall { get; set; }
        public string MoneyShallBig { get; set; }
        public decimal? MoneyActual { get; set; }
        public string Reason { get; set; }
        public int? ConfirmStatus { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public int? Voucherid { get; set; }
        public string BussinessCard { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmFinaceLoginName { get; set; }
        public string ConfirmFinaceUserIdentity { get; set; }
        public DateTime? ConfirmAuditDate { get; set; }
        public string ConfirmAuditName { get; set; }
        public string ConfirmAuditLoginName { get; set; }
        public string ConfirmAuditUserIdentity { get; set; }
        public int? BusinessObject { get; set; }
        public string PayorBank { get; set; }
        public string PayorBankCode { get; set; }
        public string BankAccount { get; set; }
        public int? PaymentMethod { get; set; }
        public string PaymentType { get; set; }
        public string Tractor { get; set; }
        public int? AttachmentNum { get; set; }
        public decimal? BudgetMoney { get; set; }
        public decimal? RemainBudget { get; set; }
        public decimal? ReimburseMoney { get; set; }
        public int? ShowPayee { get; set; }
        public int? Payee { get; set; }
        public string BillConfirmUserLogin { get; set; }
        public string BillConfirmUserName { get; set; }
    }
}
