using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSystemQueryProcessNameMap
    {
        public int Id { get; set; }
        public string UltimusProcessName { get; set; }
        public string BusinessProcessName { get; set; }
    }
}
