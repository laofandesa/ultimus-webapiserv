using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExamAtt
    {
        public int Id { get; set; }
        public int? AttId { get; set; }
        public string AttName { get; set; }
        public string CreateName { get; set; }
        public string Country { get; set; }
        public DateTime? RequsetDate { get; set; }
    }
}
