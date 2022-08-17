using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class HrpManagementAward
    {
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string Swjl1Sfzh { get; set; }
        public string Swjl1Name { get; set; }
        public string Swjl2Sfzh { get; set; }
        public string Swjl2Name { get; set; }
        public string Htbh { get; set; }
        public string Htmc { get; set; }
        public decimal? Htje { get; set; }
        public string Htqdrq { get; set; }
    }
}
