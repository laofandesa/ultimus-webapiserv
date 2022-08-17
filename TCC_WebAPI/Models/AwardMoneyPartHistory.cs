using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class AwardMoneyPartHistory
    {
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string DeptCode { get; set; }
        public string AwardComposedCode { get; set; }
        public string UserIdentityId { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string UserName { get; set; }
        public decimal? AwardMoney { get; set; }
        public int? Year { get; set; }
        public int? Qt { get; set; }
        public int DispenseTimes { get; set; }
        public int? ArchiveMonth { get; set; }
        public int? ReceiveMonth { get; set; }
        public decimal? QtMoney { get; set; }
        public decimal? DispenseMoney { get; set; }
        public string Dept { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public int Id { get; set; }
        public string IsFanPin { get; set; }
        public string Category { get; set; }
        public bool IsLeave { get; set; }
        public string MainGrpId { get; set; }
        public string BelongFlag { get; set; }
        public int ReceiveYear { get; set; }
    }
}
