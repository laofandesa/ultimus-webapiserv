using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewExpenseClaimByTripInfo
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string PersonLogin { get; set; }
        public string PersonRealName { get; set; }
        public string UserIdentity { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Days { get; set; }
    }
}
