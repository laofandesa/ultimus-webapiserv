using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ApprovedRecord02
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string StepName { get; set; }
        public int? StepId { get; set; }
        public string ApproveUserName { get; set; }
        public string ApproveUserLoginName { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string ApproveResult { get; set; }
        public int? ApproveResultCode { get; set; }
        public string ApproveRemark { get; set; }
        public int? Flag { get; set; }
    }
}
