using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class MessageSendMailError
    {
        public int MseId { get; set; }
        public int? MsId { get; set; }
        public string MseTo { get; set; }
        public string MseMail { get; set; }
        public DateTime? MseCreateTime { get; set; }
        public DateTime? MseLastSendTime { get; set; }
        public string MseTitle { get; set; }
        public string MseContent { get; set; }
        public int? MseSendCount { get; set; }
        public int? MseResult { get; set; }
        public string MseResultDesc { get; set; }
    }
}
