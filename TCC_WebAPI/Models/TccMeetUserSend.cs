using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMeetUserSend
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public int? MType { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
