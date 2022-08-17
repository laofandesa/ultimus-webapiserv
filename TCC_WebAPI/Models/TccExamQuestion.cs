using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExamQuestion
    {
        public int Id { get; set; }
        public string Qcode { get; set; }
        public string Pcode { get; set; }
        public string Qtitle { get; set; }
        public string Qexplain { get; set; }
        public int? Qtype { get; set; }
        public decimal? Score { get; set; }
        public int? SerNum { get; set; }
        public string Country { get; set; }
        public int? Belong { get; set; }
    }
}
