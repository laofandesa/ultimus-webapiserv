using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetItemConfigOther
    {
        public int Id { get; set; }
        public string BudgetItemCode { get; set; }
        public string ApplicationName { get; set; }
        public int? IsEnable { get; set; }
    }
}
