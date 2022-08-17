using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFinanceCashierConfirmDetail
    {
        public int Id { get; set; }
        public int MainId { get; set; }
        public string DraftCode { get; set; }
        public int DraftId { get; set; }
    }
}
