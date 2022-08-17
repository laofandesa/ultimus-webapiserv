using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class CheckPaymentCreateVourcherLog
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Pid { get; set; }
        public string VoucherCode { get; set; }
    }
}
