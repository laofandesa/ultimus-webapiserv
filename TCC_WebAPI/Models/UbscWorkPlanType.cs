using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class UbscWorkPlanType
    {
        public Guid UbscWorkPlanTypeOid { get; set; }
        public string PlanType { get; set; }
        public string PlanTypeNo { get; set; }
        public string PlanTypeDesc { get; set; }
        public string Status { get; set; }
        public string CycleType { get; set; }
    }
}
