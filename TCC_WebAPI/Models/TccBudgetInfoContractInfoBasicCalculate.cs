using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetInfoContractInfoBasicCalculate
    {
        public int Id { get; set; }
        public int? Flag { get; set; }
        public string ColumnName { get; set; }
        public int? OrderBy { get; set; }
        public string TargetColumn { get; set; }
        public int? CalFlag { get; set; }
    }
}
