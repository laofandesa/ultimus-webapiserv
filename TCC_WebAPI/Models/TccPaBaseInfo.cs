using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaBaseInfo
    {
        public int Id { get; set; }
        public string PaYear { get; set; }
        public string PaTimeType { get; set; }
        public string PaType { get; set; }
        public string PaSendDate { get; set; }
    }
}
