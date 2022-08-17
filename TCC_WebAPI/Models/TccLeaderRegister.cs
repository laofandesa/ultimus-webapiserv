using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccLeaderRegister
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public string AgentLoginName { get; set; }
        public string AgentDeptName { get; set; }
        public int? Daiban { get; set; }
        public string RegisterName { get; set; }
        public string RegisterUserKey { get; set; }
        public string RegisterMobile { get; set; }
        public string RegisterDeptName { get; set; }
        public string RegisterDeptNo { get; set; }
        public string RegisterPost { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TotalDays { get; set; }
        public string AimSite { get; set; }
        public string AimReason { get; set; }
        public string ApplyReason { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? IsDelete { get; set; }
    }
}
