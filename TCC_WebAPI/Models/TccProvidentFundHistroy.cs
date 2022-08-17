using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProvidentFundHistroy
    {
        public int Id { get; set; }
        public int? Month { get; set; }
        public string MonthDesc { get; set; }
        public decimal? Money { get; set; }
        public string UserIdentityId { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? Status { get; set; }
        public int? Year { get; set; }
        public int? NaShuiStatus { get; set; }
        public decimal? NaShuiTiaoZheng { get; set; }
        public int? WageYear { get; set; }
        public int? WageMonth { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
