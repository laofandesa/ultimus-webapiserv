using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewCarryoverCompany
    {
        public string Dept { get; set; }
        public string DeptCode { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string SalaryVest { get; set; }
        public string NewSalaryVest { get; set; }
        public decimal? Yanglao { get; set; }
        public decimal? Yiliao { get; set; }
        public decimal? Shiye { get; set; }
        public decimal? Gongshang { get; set; }
        public decimal? Shengyu { get; set; }
        public decimal? Qiyenianjin { get; set; }
        public decimal? Gongjijin { get; set; }
    }
}
