using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraftInfoInit
    {
        public int Id { get; set; }
        public string DraftType { get; set; }
        public int? Status { get; set; }
        public string StatusName { get; set; }
        public string DraftCode { get; set; }
        public DateTime? DrawerDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int? DueDay { get; set; }
        public string DrawerPlace { get; set; }
        public string DrawerName { get; set; }
        public string DrawerAccounts { get; set; }
        public DateTime? PutawayDate { get; set; }
        public string AcceptAgreementNumber { get; set; }
        public string Drawee { get; set; }
        public string PayingBankName { get; set; }
        public string PayingBankNumber { get; set; }
        public string PayingBankAddress { get; set; }
        public decimal? DraftAmount { get; set; }
        public string DraftAmountChineseNumeral { get; set; }
        public string DraftSource { get; set; }
        public string Currency { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string Acceptor { get; set; }
        public int? ProjectType { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string DepartName { get; set; }
        public string DepartCode { get; set; }
        public string PayeeCode { get; set; }
        public string PayeeName { get; set; }
        public string PayeeAccounts { get; set; }
        public string PayeeBank { get; set; }
        public string RecourseType { get; set; }
        public string SourceName { get; set; }
        public string SourceCode { get; set; }
        public string VoucherNumber { get; set; }
        public DateTime? CreationVoucherDate { get; set; }
        public string VoucherAbstract { get; set; }
        public string EndorseSupplier { get; set; }
        public string EndorseSupplierCode { get; set; }
        public string EndorseClientele { get; set; }
        public string EndorseAuditor { get; set; }
        public string EndorseAuditorLoginUserName { get; set; }
        public string Operator { get; set; }
        public string OperateLoginUserName { get; set; }
        public string SubmitDepartName { get; set; }
        public string SubmitDepartCode { get; set; }
        public string Submitter { get; set; }
        public string SubmitLoginUserName { get; set; }
        public DateTime? SubmitDate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountRate { get; set; }
        public int? IsPayment { get; set; }
        public int? IsLock { get; set; }
        public string LockUserLoginName { get; set; }
        public string LockUserName { get; set; }
        public string CreatorUserLoginName { get; set; }
        public string CreatorUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastStatusChangeDate { get; set; }
        public string FundsProjectCode { get; set; }
        public string FundsProjectName { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string EndorseOperator { get; set; }
        public string EndorseOperatorLoginName { get; set; }
        public DateTime? OperatorTime { get; set; }
        public DateTime? PaymentTime { get; set; }
        public string PaymentOperator { get; set; }
        public string PaymentOperatorLoginName { get; set; }
    }
}
