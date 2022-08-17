using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMessageSend
    {
        public int Id { get; set; }
        public string SendName { get; set; }
        public DateTime? SendTime { get; set; }
        public string MobileNo { get; set; }
        public string EmailTo { get; set; }
        public string Msg { get; set; }
        public string EmailTitle { get; set; }
        public string EmailContent { get; set; }
        public int? IsMsg { get; set; }
        public int? IsEmail { get; set; }
        public string ConfigFlag { get; set; }
    }
}
