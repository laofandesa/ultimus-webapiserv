using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWagePaymentQscore
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public string UserName { get; set; }
        public string UserLoginName { get; set; }
        public int? Year { get; set; }
        public decimal? Q1 { get; set; }
        public decimal? Q2 { get; set; }
        public decimal? Q3 { get; set; }
        public decimal? Q4 { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
    }
}
