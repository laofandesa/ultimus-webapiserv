using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimConfigSettingLog
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string Category { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Message { get; set; }
    }
}
