using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetBasicRowConfig
    {
        public int Id { get; set; }
        public string BdgCode { get; set; }
        public string BdgName { get; set; }
        public string ExpandColI { get; set; }
        public int? Orderby { get; set; }
        public string BdgType { get; set; }
        public int? IsEnabled { get; set; }
        public string Year { get; set; }
        public int? BatchNumber { get; set; }
        public int? IsEditThisYearUsed { get; set; }
        public int? IsEditThisYearBudget { get; set; }
    }
}
