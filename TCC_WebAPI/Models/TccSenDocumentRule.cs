using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSenDocumentRule
    {
        public int Id { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyDate { get; set; }
        public string RuleName { get; set; }
        public string RuleNo { get; set; }
        public int? IncidentNo { get; set; }
        public int? FileId { get; set; }
        public int? RuleType { get; set; }
        public int? Source { get; set; }
    }
}
