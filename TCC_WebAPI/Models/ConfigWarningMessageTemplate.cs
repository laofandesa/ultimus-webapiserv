using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigWarningMessageTemplate
    {
        public int SendType { get; set; }
        public string MsgTitle { get; set; }
        public string MsgContent { get; set; }
        public int IsEnabled { get; set; }
        public int IsDel { get; set; }
        public int? MsgType { get; set; }
        public string SendTypeName { get; set; }
        public int? IsMobile { get; set; }
    }
}
