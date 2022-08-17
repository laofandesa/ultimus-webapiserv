using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetofPayrollBreakdown
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Type { get; set; }
        public string SerialNum { get; set; }
        public string ApplyUnit { get; set; }
        public decimal? LastNumber1 { get; set; }
        public decimal? Bnys1 { get; set; }
        public decimal? Bnyszj1 { get; set; }
        public decimal? LastNumber2 { get; set; }
        public decimal? Bnys2 { get; set; }
        public decimal? Bnyszj2 { get; set; }
        public decimal? Zjfd2 { get; set; }
        public decimal? LastNumber3 { get; set; }
        public decimal? Bnys3 { get; set; }
        public decimal? Bnyszj3 { get; set; }
        public decimal? Zjfd3 { get; set; }
        public string Remark { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string MakeUnit { get; set; }
    }
}
