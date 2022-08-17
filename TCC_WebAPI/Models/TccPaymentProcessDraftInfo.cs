using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessDraftInfo
    {
        public int Id { get; set; }
        public int? PaymentId { get; set; }
        public int? DraftId { get; set; }
        public decimal? DraftAmount { get; set; }
        public int? OrderBy { get; set; }
    }
}
