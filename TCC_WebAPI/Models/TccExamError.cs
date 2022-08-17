using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExamError
    {
        public int Id { get; set; }
        public string Qcode { get; set; }
        public string Sid { get; set; }
    }
}
