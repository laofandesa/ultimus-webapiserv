using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFinanceCasierClaimHandle
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? IsAutoSend { get; set; }
        public int? IsHandle { get; set; }
        public string HandleOperater { get; set; }
        public string HandleOperaterName { get; set; }
        public DateTime? HandleTime { get; set; }
        public string SendPauseOperate { get; set; }
        public string SendPauseOperateName { get; set; }
        public DateTime? SendPauseTime { get; set; }
        public string MsgContont { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Creator { get; set; }
        public int? IsEnabled { get; set; }
        public string CancelOperate { get; set; }
        public string CancelOperateName { get; set; }
        public DateTime? CancelTime { get; set; }
    }
}
