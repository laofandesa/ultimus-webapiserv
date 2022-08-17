using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBalanceBasic
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string UserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? ApplyType { get; set; }
        public string Description { get; set; }
        public decimal? ProjectSchedule { get; set; }
        public decimal? ApplyMoney { get; set; }
        public decimal? AlterMoney { get; set; }
        public DateTime? ProPlanEndDate { get; set; }
        public DateTime? ProBeginDate { get; set; }
        public DateTime? ProEndDate { get; set; }
        public decimal? OriginalMoney { get; set; }
        public decimal? ReceiveMoney { get; set; }
        public decimal? ReceiveRate { get; set; }
        public decimal? PayableMoney { get; set; }
        public decimal? ApprovedProfit { get; set; }
        public decimal? CurrentProfit { get; set; }
        public int? IsEpc { get; set; }
        public decimal? HardwareCost { get; set; }
        public decimal? LabourCost { get; set; }
        public decimal? RunningCost { get; set; }
        public decimal? ApplyMoneyTotal { get; set; }
        public decimal? ThisTimeMoney { get; set; }
        public decimal? Pmmoney { get; set; }
        public decimal? Ptmoney { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public int? AssignStatus { get; set; }
        public DateTime? AssignDate { get; set; }
        public string ProjectManagerName { get; set; }
        public string ProjectManagerIdentity { get; set; }
        public string ProjectManagerLoginName { get; set; }
        public decimal? AlreadyApplyMoney { get; set; }
        public decimal? ForeignUnitAmount { get; set; }
        public decimal? YearAwardBudget { get; set; }
        public decimal? YearPayment { get; set; }
        public decimal? YearBalance { get; set; }
        public decimal? CurrentQapproveMoney { get; set; }
        public decimal? CurrentLeftMoney { get; set; }
        public decimal? AfterCurrentApproveLeftMoney { get; set; }
        public decimal? PoweronPayAmount { get; set; }
        public decimal? EdocPayMoney { get; set; }
        public decimal? CanApplyAmount { get; set; }
        public string CanJs { get; set; }
        public string CanYz { get; set; }
    }
}
