using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleApplicationLog
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public int? OldApplicationCode { get; set; }
        public string OldApplicationName { get; set; }
        public int? NewApplicationCode { get; set; }
        public string NewApplicationName { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
