using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWinBiddingBonusProjectAssign
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string AwardCategory { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public int? AssignFrom { get; set; }
        public string AssignFromUser { get; set; }
        public string AssignFromUserIdentity { get; set; }
        public string AssignFromUserRealName { get; set; }
        public int? ReceiverType { get; set; }
        public string ReceiverLoginName { get; set; }
        public string ReceiverRealName { get; set; }
        public string UserIdentity { get; set; }
        public string Role { get; set; }
        public string Professional { get; set; }
        public decimal? Amount { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public int? AssignStatus { get; set; }
        public DateTime? AssignDate { get; set; }
        public string IsFanPin { get; set; }
        public int? ParentId { get; set; }
        public int? RejectTimes { get; set; }
    }
}
