using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaDeptAbilityDevelop
    {
        public long Id { get; set; }
        public string AbilityDevelopField { get; set; }
        public string DevelopFieldKind { get; set; }
        public string AbilityDevelopContent { get; set; }
        public long? PersonalRecordFk { get; set; }
    }
}
