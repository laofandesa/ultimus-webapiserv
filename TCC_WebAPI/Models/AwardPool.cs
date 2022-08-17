using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class AwardPool
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string DeptCode { get; set; }
        public string Dept { get; set; }
        public string ProjectType { get; set; }
        public string AwardComposedCode { get; set; }
        public string UserName { get; set; }
        public string UserLoginName { get; set; }
        public string UserIdentityId { get; set; }
        public decimal? AwardMoney { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public int? IncidentNo { get; set; }
        public string ProcessName { get; set; }
        public decimal? ApproveMoney { get; set; }
        public string IsFanPin { get; set; }
        public string Sharer { get; set; }
        public string Summary { get; set; }
        public string BelongFlag { get; set; }
        public string Category { get; set; }
    }
}
