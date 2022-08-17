using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrpVoteAnswer
    {
        public int Id { get; set; }
        public string PaperId { get; set; }
        public int? QuestionId { get; set; }
        public int? Options { get; set; }
        public string WorkYear { get; set; }
        public string UserType { get; set; }
        public string DeptInfo { get; set; }
        public string UserIp { get; set; }
        public string UserMacIp { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
