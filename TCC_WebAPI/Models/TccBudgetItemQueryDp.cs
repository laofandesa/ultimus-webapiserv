using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetItemQueryDp
    {
        public int Id { get; set; }
        public string BudgetItemCode { get; set; }
        public string BudgetItemName { get; set; }
        public int? IsEnable { get; set; }
        public int? Category { get; set; }
        public string DeptCode { get; set; }
    }
}
