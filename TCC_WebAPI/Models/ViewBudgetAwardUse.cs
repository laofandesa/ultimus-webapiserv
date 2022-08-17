using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetAwardUse
    {
        public int? Year { get; set; }
        public string AwardComposedCode { get; set; }
        public string Deptcode { get; set; }
        public decimal? AwardMoney { get; set; }
    }
}
