using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportAwardByYear
    {
        public string UseName { get; set; }
        public string UseCode { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal? AdjustMoney { get; set; }
        public decimal Money { get; set; }
        public decimal? Surplus { get; set; }
        public int? Year { get; set; }
        public string BdgCode { get; set; }
    }
}
