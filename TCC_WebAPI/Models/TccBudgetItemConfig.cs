using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetItemConfig
    {
        public int Id { get; set; }
        public string BudgetItemCode { get; set; }
        public string BudgetItem { get; set; }
        public string ParentItemCode { get; set; }
        public string ParentItem { get; set; }
        public string ApplicationName { get; set; }
        public string BdgType { get; set; }
        public int? IsContrant { get; set; }
        public int? IsCarryout { get; set; }
        public string GeneralDp { get; set; }
        public string CentralizedDp { get; set; }
        public int IsEdited { get; set; }
        public int? IsEnable { get; set; }
        public int? TreeLevel { get; set; }
        public int? Categoty { get; set; }
        public int? OrderBy { get; set; }
    }
}
