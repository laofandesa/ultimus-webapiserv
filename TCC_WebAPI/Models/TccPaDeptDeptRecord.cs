using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaDeptDeptRecord
    {
        public int Id { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyYear { get; set; }
        public string ProcessStatus { get; set; }
        public string SubmitName { get; set; }
        public string SubmitTime { get; set; }
        public int? PainfoFk { get; set; }
    }
}
