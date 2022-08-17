using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSalaryBasic
    {
        public int Id { get; set; }
        public int? SalaryLevel { get; set; }
        public decimal? StandardSalary { get; set; }
        public decimal? FixedSalaryProportion { get; set; }
        public decimal? AllowanceProportion { get; set; }
    }
}
