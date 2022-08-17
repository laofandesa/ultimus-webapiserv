using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaDeptAbilityEvaluate
    {
        public long Id { get; set; }
        public string EvaluateField { get; set; }
        public string SelfEvaluate { get; set; }
        public string EvaluateContent { get; set; }
        public string LeaderEvaluate { get; set; }
        public long? PersonalRecordFk { get; set; }
        public int? EvaluateFieldFk { get; set; }
    }
}
