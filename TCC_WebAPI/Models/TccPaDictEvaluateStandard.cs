using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaDictEvaluateStandard
    {
        public int Id { get; set; }
        public int? EvaluateFieldFk { get; set; }
        public string EvaluateLevel { get; set; }
        public string EvaluatePoint { get; set; }
        public string EvaluateStandard { get; set; }
        public int? Sequence { get; set; }
        public int? IsDeleted { get; set; }
    }
}
