using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccYearAwardsAdjust
    {
        public int Id { get; set; }
        public int? PersonLevel { get; set; }
        public int? PostLevel { get; set; }
        public string AuditLevel { get; set; }
        public decimal? RatioOrAmount { get; set; }
        public int? Sort { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
