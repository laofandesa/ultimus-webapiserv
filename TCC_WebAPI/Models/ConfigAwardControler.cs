using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigAwardControler
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string AwardComposedCode { get; set; }
        public int? Enabled { get; set; }
        public DateTime? DisabledStartTime { get; set; }
        public DateTime? DisabledEndTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public string FaXinDi { get; set; }
    }
}
