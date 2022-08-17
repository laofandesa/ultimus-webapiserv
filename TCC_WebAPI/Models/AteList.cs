using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class AteList
    {
        public string Codesetid { get; set; }
        public string Codeitemid { get; set; }
        public string Codeitemdesc { get; set; }
        public string Parentid { get; set; }
        public string Childid { get; set; }
    }
}
