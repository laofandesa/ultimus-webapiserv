using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigWarningTime
    {
        public int SendType { get; set; }
        public int Timing { get; set; }
        public int IsEnabled { get; set; }
        public int IsDel { get; set; }
        public int? MsgType { get; set; }
    }
}
