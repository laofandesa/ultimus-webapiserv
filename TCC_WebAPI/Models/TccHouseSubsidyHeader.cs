using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHouseSubsidyHeader
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
        public int? Location { get; set; }
        public decimal? MoneyShallSmallTj { get; set; }
        public string MoneyShallBigTj { get; set; }
        public decimal? MoneyActualTj { get; set; }
        public decimal? MoneyShallSmallBj { get; set; }
        public string MoneyShallBigBj { get; set; }
        public decimal? MoneyActualBj { get; set; }
        public string Reason { get; set; }
        public int? ConfirmStatus { get; set; }
        public int? Voucherid { get; set; }
        public DateTime? ConfirmDate { get; set; }
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
        public int? AttachmentNum { get; set; }
        public string Expenseofjd { get; set; }
        public string ClaimsDepartmentName { get; set; }
        public string ClaimsDepartmentCode { get; set; }
        public int? VoucheridBj { get; set; }
        public int? ConfirmStatusBj { get; set; }
        public DateTime? ConfirmDateBj { get; set; }
        public string ConfirmFinaceNameBj { get; set; }
        public string ConfirmFinaceLoginNameBj { get; set; }
        public string ConfirmFinaceUserIdentityBj { get; set; }
        public DateTime? ConfirmAuditDateBj { get; set; }
        public string ConfirmAuditNameBj { get; set; }
        public string ConfirmAuditLoginNameBj { get; set; }
        public string ConfirmAuditUserIdentityBj { get; set; }
        public string PayorBankBj { get; set; }
        public string PayorBankCodeBj { get; set; }
        public string BankAccountBj { get; set; }
        public int? PaymentMethodBj { get; set; }
        public string PaymentTypeBj { get; set; }
        public int? AttachmentNumBj { get; set; }
        public decimal? MoneyTotal { get; set; }
        public int? Operate { get; set; }
    }
}
