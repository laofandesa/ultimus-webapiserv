using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSystemQueryStepInfo
    {
        public int Id { get; set; }
        public string BelongSystem { get; set; }
        public string ProcessName { get; set; }
        public string StepName { get; set; }
        public string Route { get; set; }
        public string QueryType { get; set; }
        public string AccessPath { get; set; }
        public string AccessLink { get; set; }
        public int? UserBookFileId { get; set; }
        public string RuleFileId { get; set; }
        public string StepNameShow { get; set; }
        public string RuleFileName { get; set; }
    }
}
