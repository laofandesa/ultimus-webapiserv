using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetType
    {
        public int Id { get; set; }
        public int? BdgType { get; set; }
        public string BdgTitle { get; set; }
        public int? AuditType { get; set; }
        public int? ShowType { get; set; }
        public int? ShowChangeType { get; set; }
        public int? ShowSumButton { get; set; }
        public int? LevelType { get; set; }
        public string BdgTypeName { get; set; }
        public string FormUrl { get; set; }
        public int? IsSingle { get; set; }
        public int? IsFinanceFinish { get; set; }
    }
}
