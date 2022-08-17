using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPrintCostProjSumMonth
    {
        public string Lxtype { get; set; }
        public string JsYm { get; set; }
        public string ProjectId { get; set; }
        public double? Totalcost { get; set; }
    }
}
