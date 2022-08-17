using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetProcess
    {
        public int Id { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestSfzh { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestFormNumber { get; set; }
        public string RequestTelephone { get; set; }
        public string CasierClaimUserName { get; set; }
        public string CasierClaimLoginUserName { get; set; }
        public DateTime? CasierClaimDate { get; set; }
        public string AccountingAuditUserName { get; set; }
        public string AccountingAuditLoginUserName { get; set; }
        public DateTime? AccountingAuditDate { get; set; }
        public string Year { get; set; }
        public string BatchNumber { get; set; }
        public decimal? Budget { get; set; }
        public decimal? UseBudget { get; set; }
        public decimal? SurplusBudget { get; set; }
        public int? BdgType { get; set; }
        public int? AuditType { get; set; }
        public string BdgTitle { get; set; }
        public int? BdgShowType { get; set; }
        public int? BdgChangeShowType { get; set; }
        public int? BdgShowSumButton { get; set; }
        public int? LevelFlag { get; set; }
    }
}
