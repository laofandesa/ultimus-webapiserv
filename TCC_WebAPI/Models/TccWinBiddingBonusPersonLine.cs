using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWinBiddingBonusPersonLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string AwardCategory { get; set; }
        public string PersonLoginName { get; set; }
        public string UserIdentity { get; set; }
        public string PersonRealName { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string DeptManagerLoginName { get; set; }
        public string DeptManagerIdentity { get; set; }
        public string DeptManagerRealName { get; set; }
        public decimal? AuditAmount { get; set; }
        public string ResponsibilityScopeRemark { get; set; }
        public string Remark { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public string IsFanPin { get; set; }
    }
}
