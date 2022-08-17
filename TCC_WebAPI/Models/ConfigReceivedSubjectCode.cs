using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigReceivedSubjectCode
    {
        public int Id { get; set; }
        public int? RequestCategory { get; set; }
        public int? IncomeType { get; set; }
        public int? Dcredit { get; set; }
        public string Digest { get; set; }
        public string SubjectCode { get; set; }
        public int? SubjectType { get; set; }
        public int? Plusminus { get; set; }
        public int? ForUse { get; set; }
    }
}
