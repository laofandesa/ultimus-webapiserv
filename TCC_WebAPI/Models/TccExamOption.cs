using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExamOption
    {
        public int Id { get; set; }
        public string Ocode { get; set; }
        public string Qcode { get; set; }
        public string Content { get; set; }
        public decimal? Score { get; set; }
        public int? SerNum { get; set; }
        public int? Num { get; set; }
    }
}
