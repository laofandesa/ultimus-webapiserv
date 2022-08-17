using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigTaskProcessFormExcludeAword
    {
        public int Id { get; set; }
        public string TaskId { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string StepLabel { get; set; }
        public string Assignedtouser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatorLoginName { get; set; }
        public int? Flag { get; set; }
        public DateTime? UpateDate { get; set; }
        public string UpdateLoginName { get; set; }
        public string DeptNo { get; set; }
    }
}
