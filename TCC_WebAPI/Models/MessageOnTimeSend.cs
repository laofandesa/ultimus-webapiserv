using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class MessageOnTimeSend
    {
        public int Id { get; set; }
        public string MsTo { get; set; }
        public string MsContent { get; set; }
        public string MsTitle { get; set; }
        public DateTime? MsCreateDate { get; set; }
        public DateTime? MsSendTime { get; set; }
        public int? MsIsSendToTable { get; set; }
        public int? MsStatus { get; set; }
        public int? MsIncidentNo { get; set; }
        public string MsProcessName { get; set; }
    }
}
