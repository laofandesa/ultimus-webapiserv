using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFinanceCasierClaimMessageSendLog
    {
        public int Id { get; set; }
        public string TaskId { get; set; }
        public DateTime? SendTime { get; set; }
        public string LoginName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string LProcessName { get; set; }
        public int? LIncident { get; set; }
    }
}
