using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetDeparment
    {
        public string Year { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string Item2 { get; set; }
        public decimal? Budget { get; set; }
        public decimal Happened { get; set; }
        public decimal Happenning { get; set; }
        public decimal? Balance { get; set; }
    }
}
