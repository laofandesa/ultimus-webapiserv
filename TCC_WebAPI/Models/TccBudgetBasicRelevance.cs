using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetBasicRelevance
    {
        public int Id { get; set; }
        public string BdgCode { get; set; }
        public string BdgType { get; set; }
        public int? LevelNo { get; set; }
        public string TargetBdgCode { get; set; }
        public string TargetBdgType { get; set; }
        public int? TargeLevelNo { get; set; }
        public int? Flag { get; set; }
    }
}
