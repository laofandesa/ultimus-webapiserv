using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProposalAnswer
    {
        public int AnserId { get; set; }
        public int? ProposalId { get; set; }
        public string AnswerType { get; set; }
        public string AnswerInfo { get; set; }
        public DateTime? AnswerTime { get; set; }
        public int? IsPublic { get; set; }
        public string AnserName { get; set; }
        public string AnswerUser { get; set; }
        public string AnswerUserKey { get; set; }
        public int? FlagStatus { get; set; }
    }
}
