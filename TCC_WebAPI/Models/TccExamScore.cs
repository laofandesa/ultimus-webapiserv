using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExamScore
    {
        public int Id { get; set; }
        public int? Pcode { get; set; }
        public string FormNumber { get; set; }
        public string Country { get; set; }
        public string Sid { get; set; }
        public decimal? Score { get; set; }
        public string Name { get; set; }
        public string UserKey { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
