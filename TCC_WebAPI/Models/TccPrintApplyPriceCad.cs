using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPrintApplyPriceCad
    {
        public int CadId { get; set; }
        public string CadYzlx { get; set; }
        public string CadCpgg { get; set; }
        public string CadPrice { get; set; }
    }
}
