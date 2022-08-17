using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPrintApplyDe
    {
        public int DeId { get; set; }
        public string DeServiceType { get; set; }
        public string DeDayLiang { get; set; }
        public string DeSize { get; set; }
        public string DeColor { get; set; }
    }
}
