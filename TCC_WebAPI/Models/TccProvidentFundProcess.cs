using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProvidentFundProcess
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string ApplyUserName { get; set; }
        public string ApplyUserLoginName { get; set; }
        public string ApplyUserIdentityId { get; set; }
        public string ApplyUserDept { get; set; }
        public string ApplyUserDeptCode { get; set; }
        public int? CreditType { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public decimal? TotalAdjusted { get; set; }
        public string Opinion { get; set; }
    }
}
