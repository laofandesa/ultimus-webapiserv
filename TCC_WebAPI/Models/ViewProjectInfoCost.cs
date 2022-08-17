using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectInfoCost
    {
        public string ProjId { get; set; }
        public double? ContCny { get; set; }
        public double? ContCost { get; set; }
        public double? CostApply { get; set; }
        public double? CostChanged { get; set; }
        public double? CostRate { get; set; }
    }
}
