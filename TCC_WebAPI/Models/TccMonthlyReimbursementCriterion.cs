using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMonthlyReimbursementCriterion
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string RealName { get; set; }
        public string UserIdentify { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal? Standard { get; set; }
    }
}
