using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFinanceLock
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string LockUsertName { get; set; }
        public string LockLoginName { get; set; }
        public DateTime? LockDate { get; set; }
    }
}
