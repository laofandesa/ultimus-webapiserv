using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaDeptOthersPa
    {
        public long Id { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyYear { get; set; }
        public string ProcessStatus { get; set; }
        public int? PainfoFk { get; set; }
    }
}
