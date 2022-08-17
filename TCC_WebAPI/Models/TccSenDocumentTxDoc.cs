using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSenDocumentTxDoc
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
        public int? DocVersion { get; set; }
        public string DocType { get; set; }
        public int? HasAtt { get; set; }
    }
}
