using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectLoanApplication
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerLoginName { get; set; }
        public string CardholdName { get; set; }
        public string CardholdLogin { get; set; }
        public string CardholdUserIdentity { get; set; }
        public string BankName { get; set; }
        public string PayCheque { get; set; }
        public string CardCurrency { get; set; }
        public decimal? Quota { get; set; }
        public decimal? QuotaYb { get; set; }
        public string Enabled { get; set; }
        public string Delegation { get; set; }
        public string DelegationLoginname { get; set; }
        public string DelegationUserIdentityId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? BorrowUse { get; set; }
        public DateTime? EnabledDate { get; set; }
        public DateTime? EnabledEndDate { get; set; }
        public int? IsDelay { get; set; }
        public int? IsChangeAmount { get; set; }
        public int? IsTemporarilyDisable { get; set; }
        public decimal? FirstQuotaYb { get; set; }
        public DateTime? FirstEnabledEndDate { get; set; }
        public string Deptcode { get; set; }
    }
}
