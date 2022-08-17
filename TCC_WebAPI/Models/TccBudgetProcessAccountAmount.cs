using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetProcessAccountAmount
    {
        public int Sid { get; set; }
        public int? Bid { get; set; }
        public string BdgCode { get; set; }
        public string BdgName { get; set; }
        public string ParentBdgCode { get; set; }
        public string SubjectCode { get; set; }
        public int? Orderby { get; set; }
        public string BdgType { get; set; }
        public string Year { get; set; }
        public string BatchNumber { get; set; }
        public decimal? LastYearBudget { get; set; }
        public decimal? LastYearUsed { get; set; }
        public decimal? ThisYearBudget { get; set; }
        public decimal? ThisYearUsed { get; set; }
        public decimal? NextYearChange { get; set; }
        public decimal? BdgAmount { get; set; }
        public string BdgNote { get; set; }
        public decimal? FinanceBdgAmount { get; set; }
        public string NextChangeColumn { get; set; }
        public string NextChangeName { get; set; }
        public int? FormatType { get; set; }
        public string DeptCode { get; set; }
        public decimal? BdgAmountZjl { get; set; }
    }
}
