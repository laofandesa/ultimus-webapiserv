using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectArtificialTimeHistory
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string AwardCode { get; set; }
        public string ProjectCode { get; set; }
    }
}
