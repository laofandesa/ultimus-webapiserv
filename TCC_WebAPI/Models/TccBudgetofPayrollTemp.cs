using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetofPayrollTemp
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Type { get; set; }
        public string SerialNum { get; set; }
        public string ApplyUnit { get; set; }
        public string ExpandColI { get; set; }
        public decimal? LastNumber1 { get; set; }
        public decimal? Bnys1 { get; set; }
        public decimal? Zjfd1 { get; set; }
        public string Remark { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string MakeUnit { get; set; }
    }
}
