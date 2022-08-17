using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectAwardApplyProcess
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? Status { get; set; }
        public string ApplyUserName { get; set; }
        public string ApplyUserLoginName { get; set; }
        public string IdentityId { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string FormNumber { get; set; }
        public string ProjectType { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? ContractMoney { get; set; }
        public string ContractType { get; set; }
        public decimal? ProjectAward { get; set; }
        public decimal? PaymentyMoney { get; set; }
        public decimal? Balances { get; set; }
        public decimal? CurrentMoney { get; set; }
        public decimal? Proportion { get; set; }
        public decimal? ActivityAward { get; set; }
        public decimal? AdjustAward { get; set; }
        public decimal? ProjectStatus { get; set; }
        public decimal? ContractChargeProportion { get; set; }
        public string ProjectDesc { get; set; }
        public int? FirstAssignPlan { get; set; }
        public int? SecondAssignPlan { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDeptCode { get; set; }
        public int? AwardStatus { get; set; }
        public string AwardComposeCode { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public decimal? ReceiveMoney { get; set; }
        public decimal? ZanTiaoAwardMoney { get; set; }
        public decimal? ApproveMoney { get; set; }
        public decimal? PorjectApproveProjectStatus { get; set; }
        public decimal? ProjectApproveAdjustAward { get; set; }
        public decimal? ProjectManagerApproveMoney { get; set; }
        public decimal? ProjectManagerAdjustMoney { get; set; }
        public decimal? ProjectManagerProjectStatus { get; set; }
        public decimal? YearAwardBudget { get; set; }
        public decimal? YearPayment { get; set; }
        public decimal? YearBalance { get; set; }
        public decimal? CurrentQapproveMoney { get; set; }
        public decimal? CurrentLeftMoney { get; set; }
        public decimal? AfterCurrentApproveLeftMoney { get; set; }
        public decimal? PorjectApproveBiLi { get; set; }
        public decimal? ProjectManagerBiLi { get; set; }
        public decimal? ForeignUnitAmount { get; set; }
        public decimal? OldProjectAward { get; set; }
        public decimal? OldZanTiaoAwardMoney { get; set; }
        public decimal? ManageAward { get; set; }
        public decimal? ProjectApproveManageAward { get; set; }
        public decimal? ProjectManagerManageMoney { get; set; }
        public string ProjectDetailStatus { get; set; }
    }
}
