using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFinanceCashierConfirmVoucherInfo
    {
        public int Id { get; set; }
        public int? Fid { get; set; }
        public int? VoucherId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Flag { get; set; }
    }
}
