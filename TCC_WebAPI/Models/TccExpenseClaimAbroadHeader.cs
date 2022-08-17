using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimAbroadHeader
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestUserIdentity { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? Agency { get; set; }
        public string FormNumber { get; set; }
        public string ExpenseCategory { get; set; }
        public string TravelClaimCategory { get; set; }
        public string TravelCategory { get; set; }
        public string TravelCategory1 { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public int? TravelClaimDays { get; set; }
        public int? TravelDomesticOversea { get; set; }
        public string TravelRemark { get; set; }
        public decimal? MoneyShallSmall { get; set; }
        public string MoneyShallBig { get; set; }
        public decimal? MoneyActual { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public int? ConfirmStatus { get; set; }
        public string BeyondReason { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmUserIdentity { get; set; }
        public string ConfirmLoginName { get; set; }
        public DateTime? ConfirmFinaceDate { get; set; }
        public string ConfirmAuditorName { get; set; }
        public string ConfirmAuditorLoginName { get; set; }
        public string ConfirmAuditorUserIdentity { get; set; }
        public DateTime? ConfirmAuditorDate { get; set; }
        public string TelPhone { get; set; }
        public int? Location { get; set; }
        public string AdressLocation { get; set; }
        public string Currency { get; set; }
        public string CurrencyName { get; set; }
        public string TravelToPlace { get; set; }
        public decimal? ShenlingtoCountRate { get; set; }
        public decimal? ShenlingtoRmbrate { get; set; }
        public string PayorBank { get; set; }
        public string PayorBankCode { get; set; }
        public string BankAccount { get; set; }
        public int? PaymentMethod { get; set; }
        public string PaymentType { get; set; }
        public int? AttachmentNum { get; set; }
        public int? Voucherid { get; set; }
        public string AbroadInfoCard { get; set; }
        public string Cardholder { get; set; }
        public string CardholdLogin { get; set; }
        public string CardholdUserIdentity { get; set; }
        public string CardholderDept { get; set; }
        public string CardholderDeptName { get; set; }
        public decimal? CardYuE { get; set; }
        public string BorrowCurrency { get; set; }
        public decimal? BorrowBalance { get; set; }
        public decimal? FinanceRate { get; set; }
        public decimal? FinanceRateForCountBz { get; set; }
        public decimal? FinanceAmountRmb { get; set; }
        public string ClaimsDepartmentCode { get; set; }
        public string ClaimsDepartmentName { get; set; }
        public string ReCountCurrency { get; set; }
        public int? IsConsolidated { get; set; }
    }
}
