using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectApprovedCost
    {
        public string ProjId { get; set; }
        public string ProjName { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public double ContCost { get; set; }
        public double HourApply { get; set; }
        public double CostApply { get; set; }
        public double HourApprove { get; set; }
        public double CostApprove { get; set; }
        public double CostChanged { get; set; }
    }
}
