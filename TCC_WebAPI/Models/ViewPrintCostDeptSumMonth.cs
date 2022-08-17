using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPrintCostDeptSumMonth
    {
        public string Lxtype { get; set; }
        public string Deptid { get; set; }
        public string JsYm { get; set; }
        public double? Totalcost { get; set; }
    }
}
