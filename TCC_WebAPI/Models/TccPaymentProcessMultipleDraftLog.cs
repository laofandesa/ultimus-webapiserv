using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleDraftLog
    {
        public long Id { get; set; }
        public string Method { get; set; }
        public int? OldPaymentId { get; set; }
        public int? OldDraftId { get; set; }
        public int? NewPaymentId { get; set; }
        public int? NewDraftId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
