using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetInfoContractInfoBasic
    {
        public int Id { get; set; }
        public int? Flag { get; set; }
        public string ColumnName { get; set; }
        public string ColumnAbbreviation { get; set; }
        public int? ColumnType { get; set; }
        public string ColumnTitle { get; set; }
        public int? DataType { get; set; }
        public int? DecimalDigits { get; set; }
        public string Note { get; set; }
        public int? OrderBy { get; set; }
        public int? IsShow { get; set; }
        public int? IsEdit { get; set; }
        public int? RowspanNo { get; set; }
        public int? IsFrozenColumns { get; set; }
        public int? IsPercent { get; set; }
        public decimal? ColumnWidth { get; set; }
        public string ColumnAlign { get; set; }
        public string Dbformat { get; set; }
    }
}
