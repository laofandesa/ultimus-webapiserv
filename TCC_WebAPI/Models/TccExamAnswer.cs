using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExamAnswer
    {
        public long Id { get; set; }
        public string Pcode { get; set; }
        public string Qcode { get; set; }
        public string Country { get; set; }
        public string UserName { get; set; }
        public string UserKey { get; set; }
        public string Val { get; set; }
        public string FormNumber { get; set; }
        public string Sid { get; set; }
    }
}
