using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBalanceCostList
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? CostTypeId { get; set; }
        public decimal? ApproveMoney { get; set; }
        public decimal? AdjustApproveMoney { get; set; }
        public decimal? Acwp { get; set; }
        public decimal? Acwp2 { get; set; }
        public decimal? BalanceMoney { get; set; }
    }
}
