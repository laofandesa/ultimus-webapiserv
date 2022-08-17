using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetTelephoneSubsidy
    {
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal Budget { get; set; }
        public decimal HasBudget { get; set; }
        public decimal? RemainBudget { get; set; }
    }
}
