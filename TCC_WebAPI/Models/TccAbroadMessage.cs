using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbroadMessage
    {
        public int Id { get; set; }
        public int? PId { get; set; }
        public int? MessageType { get; set; }
        public string ReceiveUser { get; set; }
        public string ReceivePhone { get; set; }
        public string ReceiveMail { get; set; }
        public string ReceiveContent { get; set; }
        public DateTime? ReceiveDate { get; set; }
    }
}
