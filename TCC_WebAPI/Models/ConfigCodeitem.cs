using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigCodeitem
    {
        public string Codeitemid { get; set; }
        public string Codeitemdesc { get; set; }
        public string Codesetid { get; set; }
        public string Codesetinfo { get; set; }
        public string OtherId { get; set; }
        public int? Number { get; set; }
    }
}
