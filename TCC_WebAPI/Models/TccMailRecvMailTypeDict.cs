using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMailRecvMailTypeDict
    {
        public int Id { get; set; }
        public string MailTypeName { get; set; }
        public string MailTypeValue { get; set; }
        public int? IsDelete { get; set; }
    }
}
