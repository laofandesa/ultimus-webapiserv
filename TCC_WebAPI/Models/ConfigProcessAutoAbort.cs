using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigProcessAutoAbort
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public DateTime? OverTime { get; set; }
        public int? OverDays { get; set; }
        public int? Enabled { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? MessageSendTime { get; set; }
        public int? Source { get; set; }
        public string Steplabel { get; set; }
        public string Steplabelnext { get; set; }
    }
}
