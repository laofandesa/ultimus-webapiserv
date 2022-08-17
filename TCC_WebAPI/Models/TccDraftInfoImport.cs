using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraftInfoImport
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string VoucherCode { get; set; }
        public int? VoucherId { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string CreatorUserLoginName { get; set; }
        public string CreatorUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? SubmitDate { get; set; }
        public int? Flag { get; set; }
        public string Auditor { get; set; }
        public string AuditorLoginname { get; set; }
        public int? Status { get; set; }
        public string StatusName { get; set; }
        public string DraftType { get; set; }
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
        public string DraftSource { get; set; }
        public string Currency { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string Acceptor { get; set; }
        public int? ProjectIsEpc { get; set; }
        public int? ProjectType { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string DepartName { get; set; }
        public string DepartCode { get; set; }
        public string PayeeName { get; set; }
        public string PayeeAccounts { get; set; }
        public string PayeeBank { get; set; }
        public string PayeeCode { get; set; }
        public string RecourseType { get; set; }
        public string SourceName { get; set; }
        public string SourceCode { get; set; }
        public string FundsProjectCode { get; set; }
        public string FundsProjectName { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int? Attachment { get; set; }
    }
}
