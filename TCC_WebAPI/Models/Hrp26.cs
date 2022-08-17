using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class Hrp26
    {
        public int Id { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string Swjl1Sfzh { get; set; }
        public string Swjl1Name { get; set; }
        public string Swjl2Sfzh { get; set; }
        public string Swjl2Name { get; set; }
        public string Htbh { get; set; }
        public string Htmc { get; set; }
        public string Htlx { get; set; }
        public decimal? Htje { get; set; }
        public decimal? Bgje { get; set; }
        public decimal? Bghje { get; set; }
        public decimal? Gsje { get; set; }
        public string Htqdrq { get; set; }
        public string HtqdrName { get; set; }
        public string Proid { get; set; }
        public string ProjectName { get; set; }
        public string XmjlName { get; set; }
    }
}
