using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWinBiddingBonusLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string AwardCategory { get; set; }
        public string ProjectCategory { get; set; }
        public string BidProjectCode { get; set; }
        public string BidProjectName { get; set; }
        public string BidProjectManager { get; set; }
        public string BidProjectManagerIdentity { get; set; }
        public string BidProjectManagerRealName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerIdentity { get; set; }
        public string ProjectManagerRealName { get; set; }
        public decimal? ContractPrice { get; set; }
        public decimal? ChargingCoefficient { get; set; }
        public decimal? Adjustment { get; set; }
        public decimal? AuditAmount { get; set; }
        public decimal? ProjectAmount { get; set; }
        public decimal? ChargeAmount { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public int? BidManagerAssignStatus { get; set; }
        public DateTime? BidManagerAssignDate { get; set; }
        public string OpDeptManager { get; set; }
        public string OpDeptManagerIdentity { get; set; }
        public string OpDeptManagerRealName { get; set; }
        public decimal? OpDeptAmount { get; set; }
        public int? OpDeptAssignStatus { get; set; }
        public DateTime? OpDeptAssignDate { get; set; }
        public string BidDeptManager { get; set; }
        public string BidDeptManagerIdentity { get; set; }
        public string BidDeptManagerRealName { get; set; }
        public decimal? BidDeptAmount { get; set; }
        public int? BidDeptAssignStatus { get; set; }
        public DateTime? BidDeptAssignDate { get; set; }
    }
}
