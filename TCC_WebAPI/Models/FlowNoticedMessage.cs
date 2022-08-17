using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FlowNoticedMessage
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public int? MType { get; set; }
    }
}
