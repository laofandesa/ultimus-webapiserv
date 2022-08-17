using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class CopiedTask
    {
        public string TaskId { get; set; }
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public DateTime StartTime { get; set; }
        public string TaskUser { get; set; }
        public string AssignedToUser { get; set; }
        public int Status { get; set; }
        public string StepLabel { get; set; }
        public DateTime? EndTime { get; set; }
        public int? SubStatus { get; set; }
        public string StepId { get; set; }
    }
}
