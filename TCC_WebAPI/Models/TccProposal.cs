using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProposal
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public int? ApplyType { get; set; }
        public DateTime? RequestDate { get; set; }
        public string PropType { get; set; }
        public string ApplyLoginName { get; set; }
        public string ApplyName { get; set; }
        public string ApplyMobile { get; set; }
        public string ApplyUnion { get; set; }
        public string ApplyUnionNo { get; set; }
        public string AttNames { get; set; }
        public string PropSugest { get; set; }
        public string PropReason { get; set; }
        public string PropContent { get; set; }
    }
}
