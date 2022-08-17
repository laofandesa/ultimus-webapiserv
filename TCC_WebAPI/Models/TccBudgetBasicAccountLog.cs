using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetBasicAccountLog
    {
        public int Id { get; set; }
        public string BdgCode { get; set; }
        public string BdgName { get; set; }
        public string ParentBdgCode { get; set; }
        public string SubjectCode { get; set; }
        public int? Orderby { get; set; }
        public string BdgType { get; set; }
        public int? IsEnabled { get; set; }
        public string Year { get; set; }
        public string BatchNumber { get; set; }
        public int? IsTotal { get; set; }
        public int? IsEditThisYearBudget { get; set; }
        public int? IsEditThisYearUsed { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Flag { get; set; }
    }
}
