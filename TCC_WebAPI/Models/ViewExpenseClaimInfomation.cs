using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewExpenseClaimInfomation
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string LoginName { get; set; }
        public string RealName { get; set; }
        public string UserIdentity { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? TotalDays { get; set; }
    }
}
