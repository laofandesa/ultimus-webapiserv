using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetHistory
    {
        public int Id { get; set; }
        public string RequestName { get; set; }
        public string RequestLogin { get; set; }
        public string RequestSfzh { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestDeptCode { get; set; }
        public int? ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public decimal? Amount { get; set; }
        public string Currency { get; set; }
        public decimal? Exchange { get; set; }
        public decimal? AmountRmb { get; set; }
        public string Remark { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string FormNumber { get; set; }
        public DateTime? AccountDate { get; set; }
        public int? VoucherId { get; set; }
        public int? Vchrnum { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string BudgetProjectCode { get; set; }
        public string BudgetProjectName { get; set; }
        public string BudgetDeptCode { get; set; }
        public string BudgetDeptName { get; set; }
        public string CostProjectCode { get; set; }
        public string CostProjectName { get; set; }
        public string CostDeptCode { get; set; }
        public string CostDeptName { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public int? RunningCost { get; set; }
        public string Year { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SFlag { get; set; }
    }
}
