using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewApprovedRecordDistinct
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string ApproveUserLoginName { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string StepName { get; set; }
        public long? Rn { get; set; }
    }
}
