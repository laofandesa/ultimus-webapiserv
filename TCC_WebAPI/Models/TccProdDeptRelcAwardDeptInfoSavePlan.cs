using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProdDeptRelcAwardDeptInfoSavePlan
    {
        public string DeptCode { get; set; }
        public string ApplyDept { get; set; }
        public int? PersonNum { get; set; }
        public int? AwayDays { get; set; }
        public decimal? WorkOverTime { get; set; }
    }
}
