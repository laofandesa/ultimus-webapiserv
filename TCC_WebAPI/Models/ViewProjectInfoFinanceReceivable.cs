using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectInfoFinanceReceivable
    {
        public string Proid { get; set; }
        public string ProjectName { get; set; }
        public decimal? Hthv { get; set; }
        public double? Total { get; set; }
        public double? TotalOc { get; set; }
        public decimal Ramount { get; set; }
        public decimal RamountOc { get; set; }
        public decimal RamountCny { get; set; }
        public decimal RamountCnyforPer { get; set; }
        public double? RperOc { get; set; }
        public double? RperCny { get; set; }
        public string Bz { get; set; }
    }
}
