using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsDictPlanDetail0321
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string PlanLevel { get; set; }
        public string DeptId { get; set; }
        public int? OrderId { get; set; }
        public string PlanYear { get; set; }
        public string Needed { get; set; }
    }
}
