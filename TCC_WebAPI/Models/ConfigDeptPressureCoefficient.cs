using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigDeptPressureCoefficient
    {
        public int? Id { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal? Coefficient { get; set; }
    }
}
