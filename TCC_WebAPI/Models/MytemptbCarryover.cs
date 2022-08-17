using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class MytemptbCarryover
    {
        public string Direction { get; set; }
        public string DeptCode { get; set; }
        public string Dept { get; set; }
        public string CostType { get; set; }
        public int? Month { get; set; }
        public decimal? TotalMoney { get; set; }
        public string SubjectCode { get; set; }
    }
}
