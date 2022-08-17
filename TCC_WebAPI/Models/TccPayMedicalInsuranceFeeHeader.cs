using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPayMedicalInsuranceFeeHeader
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public int? RequestUserPost { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelPhone { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? RequestFinishDate { get; set; }
        public string FormNumber { get; set; }
        public int? Location { get; set; }
        public string LocationName { get; set; }
        public int? ExpenseCategory { get; set; }
        public string ExpenseCategoryName { get; set; }
        public decimal? MoneyShallSmall { get; set; }
        public string MoneyShallBig { get; set; }
        public decimal? MoneyActual { get; set; }
        public string Summmay { get; set; }
        public int? ConfirmStatus { get; set; }
        public int? Voucherid { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmUserIdentity { get; set; }
        public string ConfirmLoginName { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string ConfirmAuditName { get; set; }
        public string ConfirmAuditLoginName { get; set; }
        public string ConfirmAuditUserIdentity { get; set; }
        public DateTime? ConfirmAuditDate { get; set; }
        public string PayorBank { get; set; }
        public string PayorBankCode { get; set; }
        public string BankAccount { get; set; }
        public int? AttachmentNum { get; set; }
        public int? PaymentMethod { get; set; }
        public string PaymentType { get; set; }
    }
}
