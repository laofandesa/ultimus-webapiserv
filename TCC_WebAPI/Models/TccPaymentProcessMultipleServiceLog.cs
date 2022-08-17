using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleServiceLog
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Status { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
