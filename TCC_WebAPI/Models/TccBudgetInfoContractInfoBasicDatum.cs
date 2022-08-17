using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetInfoContractInfoBasicDatum
    {
        public int Id { get; set; }
        public int? Flag { get; set; }
        public string RowName { get; set; }
        public string ColumnVarcher1 { get; set; }
        public string ColumnVarcher2 { get; set; }
        public int? Year { get; set; }
        public int? OrderBy { get; set; }
    }
}
