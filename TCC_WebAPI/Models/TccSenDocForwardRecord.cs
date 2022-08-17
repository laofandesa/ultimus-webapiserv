using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSenDocForwardRecord
    {
        public int Id { get; set; }
        public int? SenDocIncidentNo { get; set; }
        public string SendFromRealName { get; set; }
        public string SendFromloginName { get; set; }
        public string SendToRealName { get; set; }
        public string SendTologinName { get; set; }
        public string SendOption { get; set; }
    }
}
