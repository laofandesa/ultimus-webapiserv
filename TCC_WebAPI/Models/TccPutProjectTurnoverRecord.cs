using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPutProjectTurnoverRecord
    {
        public int Id { get; set; }
        public string ApplyUser { get; set; }
        public string ApplyUserLoginName { get; set; }
        public string ApplyUserIdentityId { get; set; }
        public string DpetName { get; set; }
        public string DeptCode { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerLoginName { get; set; }
        public string ProjectManagerUserIdentityid { get; set; }
        public DateTime? ProjectBeginDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public int? ForecastPersonNo { get; set; }
        public string ProjectPlace { get; set; }
        public string CardHolder { get; set; }
        public string CardHolderLoginname { get; set; }
        public string CardHolderUserIdentityId { get; set; }
        public string BankAccountNo { get; set; }
        public string BankName { get; set; }
        public DateTime? EnabledDate { get; set; }
        public string ForUse { get; set; }
        public string ReimbursementManager { get; set; }
        public string ReimbursementManagerLoginname { get; set; }
        public string ReimbursementManagerUserIdentityId { get; set; }
        public decimal? ContractAmount { get; set; }
        public decimal? PaymentCeiling { get; set; }
        public string Supervisor { get; set; }
        public string SupervisorLoginname { get; set; }
        public string SupervisorUserIdentityid { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? Status { get; set; }
        public decimal? OldMoney { get; set; }
        public int? IsApprove { get; set; }
        public int? IsChangePaymentCeiling { get; set; }
        public int? ApplyType { get; set; }
        public string CardCurrency { get; set; }
        public string BalanceCeiling { get; set; }
        public string PayTaxRate { get; set; }
        public string TaxRate { get; set; }
        public decimal? PayRmb { get; set; }
        public decimal? Rmb { get; set; }
        public DateTime? EnabledEndDate { get; set; }
    }
}
