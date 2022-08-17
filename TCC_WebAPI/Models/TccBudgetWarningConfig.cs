using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetWarningConfig
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string DeptCode { get; set; }
        public int? Year { get; set; }
        public string RoleId { get; set; }
        public string RoleId2 { get; set; }
        public int? LevelFlag { get; set; }
        public int? BudgetType { get; set; }
        public string BudgetCode { get; set; }
    }
}
