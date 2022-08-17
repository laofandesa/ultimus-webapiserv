using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaDictEvaluateField
    {
        public int Id { get; set; }
        public string EvaluatePersonType { get; set; }
        public string EvaluateType { get; set; }
        public string EvaluateField { get; set; }
        public int? Sequence { get; set; }
        public int? IsDeleted { get; set; }
    }
}
